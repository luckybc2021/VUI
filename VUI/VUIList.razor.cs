using Microsoft.AspNetCore.Components;

namespace VUI
{
    public partial class VUIList<TItem>
    {
        [Parameter]
        public RenderFragment<TItem> ChildContent { get; set; } = default!;

        [Parameter, EditorRequired]
        public IReadOnlyList<TItem> Items { get; set; } = default!;


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

        private string fontSize = "unset";
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


        protected override void OnInitialized()
        {
            ContentType = "List";
            Display = "inline-block";
            Position = "relative";
            
            base.OnInitialized();
        }
    }
}