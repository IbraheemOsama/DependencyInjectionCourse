using System.Web.Mvc;
using AutofacWebMvcFive.Repositories;

namespace AutofacWebMvcFive.CustomPages
{
    public class CustomBasePage : WebViewPage
    {
        public IDataRepository DataRepository { get; set; }

        public override void Execute() { }
    }
}