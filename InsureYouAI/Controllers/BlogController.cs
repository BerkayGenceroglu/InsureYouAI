using InsureYouAI.Context;
using InsureYouAI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace InsureYouAI.Controllers
{
    public class BlogController : Controller
    {
        private readonly InsureContext _context;
        private readonly ILogger<BlogController> _logger;
        public BlogController(InsureContext context, ILogger<BlogController> logger)
        {
            _context = context;
            _logger = logger;
        }
        public IActionResult GetBlogByCategory(int id)
        {
            ViewBag.CategoryId = id;    
            return View();
        }

        public IActionResult BlogList()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult GetBlog()
        {
            return PartialView();
        }
        public IActionResult GetBlog(string KeyWord)
        {
            return View();
        }
        public IActionResult BlogDetail(int id)
        {
            var value = _context.Articles.Find(id);
            if (value != null)
            {
                ViewBag.ArticleId = value.ArticleId;
            }
            else
            {
                return View();
            }
            return View();
        }
        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }
        public async Task<IActionResult> AddComment(Comment comment)
        {
            comment.CommentStatus = "Yorum Onaylandı";
            comment.CommentDate = DateTime.Now;
            comment.AppUserId = "683b2441-42ab-45e6-8801-2f2234cbcdd7";
            using (var client = new HttpClient())
            {
                var apiKey = "";
                client.DefaultRequestHeaders.Authorization= new AuthenticationHeaderValue("Bearer", apiKey);
                try
                {
                    var translateRequestBody = new
                    {
                        inputs = comment.CommentDetail,
                    };
                    var translateJson = JsonSerializer.Serialize(translateRequestBody);
                    var translateContent = new StringContent(translateJson, Encoding.UTF8, "application/json");
                    var translateResponse = await client.PostAsync("https://api-inference.huggingface.co/models/Helsinki-NLP/opus-mt-tr-en", translateContent);
                    var translateResponseString = await translateResponse.Content.ReadAsStringAsync();

                    string EnglishText = comment.CommentDetail;

                    if (translateResponseString.TrimStart().StartsWith("["))
                    {
                        var translateDoc = JsonDocument.Parse(translateResponseString);
                        EnglishText = translateDoc.RootElement[0].GetProperty("translation_text").GetString()!;
                    }

                    //--------------------
                    var toxicRequestBody = new
                    {
                        inputs = comment.CommentDetail,
                    };
                    var toxicJson = JsonSerializer.Serialize(toxicRequestBody);
                    var toxicContent = new StringContent(toxicJson, Encoding.UTF8, "application/json");
                    var toxicResponse = await client.PostAsync("https://router.huggingface.co/hf-inference/models/unitary/multilingual-toxic-xlm-roberta", toxicContent);
                    var toxicResponseString = await toxicResponse.Content.ReadAsStringAsync();
                    if (toxicResponseString.TrimStart().StartsWith("["))
                    {
                        var toxicDoc = JsonDocument.Parse(toxicResponseString);
                        //EnumerateArray:bir JSON array (dizi) içindeki elemanları tek tek dolaşmamızı (iterate etmemizi) sağlayan bir metottur.
                        foreach (var item in toxicDoc.RootElement[0].EnumerateArray())
                        {
                            string label = item.GetProperty("label").GetString()!;
                            double score = item.GetProperty("score").GetSingle();
                            if (score > 0.5)
                            {
                                comment.CommentStatus = "Toksik Yorum";
                                break;
                            }
                        }
                    }
                    if (string.IsNullOrEmpty(comment.CommentStatus))
                    {
                        comment.CommentStatus = "Yorum Onaylandı";
                    }
                }
                catch (Exception ex)
                {
                    comment.CommentStatus = "Yorum Onaylandı";
                }
            }
            _context.Comments.Add(comment);
            _context.SaveChanges();
            return RedirectToAction("BlogDetail", new { id =comment.ArticleId });
        }
    }
}
