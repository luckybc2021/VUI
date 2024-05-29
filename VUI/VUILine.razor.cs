using Microsoft.AspNetCore.Components;

namespace VUI
{
    public partial class VUILine<TItem> : IVUIText
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }

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


        /// <summary>
        /// To create a line of UIElements:
        /// <list type="bullet">
        /// <item> <description>display: inline-flex; // Use flexbox</description> </item>
        /// <item> <description>flex-flow: row;</description> </item>
        /// <item> <description>width: max-content;</description> </item>
        /// </list>
        /// </summary>
        protected override void OnInitialized()
        {
            ContentType = "Line";
            
            Display = "inline-flex";
            FlexFlow = "row";

            if (Width == "unset")
            {
                Width = "max-content";
            }    

            base.OnInitialized();
        }

        protected override void OnParametersSet()
        {


            base.OnParametersSet();

            StateHasChanged();
        }
    }
}