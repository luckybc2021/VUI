using Microsoft.AspNetCore.Components;

namespace VUI
{
    public partial class VUILine<TItem>
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        [Parameter, EditorRequired]
        public IReadOnlyList<TItem> Items { get; set; } = default!;

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