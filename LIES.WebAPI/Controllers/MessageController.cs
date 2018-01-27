using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LIES.WebAPI.Models;

namespace LIES.WebAPI.Controllers
{
    public class MessageController : Controller
    {
        public ActionResult GetRandomMessages(
            string templateId,
            int level
        )
        {
            using (var db = new LiesDatabase())
            {
                var messages = db.GetRandomMessages(
                    templateId: templateId,
                    level: level
                ).ToList();
                return Json(messages, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult InsertMessage(
            string templateId,
            int level,
            string text
        )
        {
            using (var db = new LiesDatabase())
            {
                db.InsertMessage(
                    templateId: templateId,
                    level: level,
                    text: text
                );
            }
            return Json("Success", JsonRequestBehavior.DenyGet);
        }

        [HttpPost]
        public ActionResult InsertDeathes(
            Guid messageId,
            string templateId,
            int level,
            int deaths
        )
        {
            using (var db = new LiesDatabase())
            {
                db.InsertDeathes(
                    messageId: messageId,
                    templateId: templateId,
                    level: level,
                    deaths: deaths
                );
            }
            return Json("Success", JsonRequestBehavior.DenyGet);
        }

        [HttpPost]
        public ActionResult InsertUpDownVotes(
            Guid messageId,
            string templateId,
            int level,
            int upVotes,
            int downVotes
        )
        {
            using (var db = new LiesDatabase())
            {
                db.InsertUpDownVotes(
                    messageId: messageId,
                    templateId: templateId,
                    level: level,
                    upVotes: upVotes,
                    downVotes: downVotes
                );
            }
            return Json("Success", JsonRequestBehavior.DenyGet);
        }
    }
}