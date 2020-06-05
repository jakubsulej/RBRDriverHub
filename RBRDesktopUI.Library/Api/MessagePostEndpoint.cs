using RBRDesktopUI.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RBRDesktopUI.Library.Api
{
    public class MessagePostEndpoint : IMessagePostEndpoint
    {
        private IAPIHelper _apiHelper;

        public MessagePostEndpoint(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public async Task PostMessage(MessagePostModel messagePost)
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("/api/MessagePost", messagePost))
            {
                if (response.IsSuccessStatusCode)
                {
                    //Log succesfull call?
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
