using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.JSInterop;
using System.Net.Mime;
using System.Text;

namespace VUI
{
    public partial class VUIText
    {
        private string content = "";


        public string Content
        {
            get => content;
        }

        protected override void OnInitialized()
        {
            ContentType = "Text";            
            base.OnInitialized();
        }

        protected override async void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);

            await ExtractContent();
        }

        /// <summary>
        /// To obtain a text from the ChildContent.
        /// </summary>
        private async Task<string> ExtractContent()
        {
            // Invoke the JavaScript function to get the inner HTML
            content = await JSRuntime.InvokeAsync<string>("getInnerHtml", [ID]);

            return content;
        }
    }
}