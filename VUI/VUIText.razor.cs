using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.JSInterop;
using System.Net.Mime;
using System.Text;

namespace VUI
{
    public partial class VUIText: IVUIText
    {
        private string content = "";

        public string Content
        {
            get => content;
        }

        
        private string fontFamily = "arial";
        [Parameter]
        public string FontFamily 
        { 
            get => fontFamily; 
            set
            {
                fontFamily = value;
            }
        }

        private string fontSize = "initial";
        [Parameter]
        public string FontSize
        {
            get => fontSize;
            set
            {
                fontSize = value;
            }
        }

        private string fontWeight = "normal";
        [Parameter]
        public string FontWeight
        {
            get => fontWeight;
            set
            {
                fontWeight = value;
            }
        }

        [Parameter]
        public RenderFragment? ChildContent { get; set; }


        protected override void OnInitialized()
        {
            ContentType = "Text";
            base.OnInitialized();
        }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
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