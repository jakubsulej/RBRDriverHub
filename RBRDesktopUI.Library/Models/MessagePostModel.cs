using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBRDesktopUI.Library.Models
{
    public class MessagePostModel
    {
        public List<MessagePostDetailModel> MessagePostDetails { get; set; } = new List<MessagePostDetailModel>();
    }
}