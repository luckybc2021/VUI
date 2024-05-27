using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System.Net.Mime;

namespace VUI
{
    public partial class VUIPiece
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        protected override void OnInitialized()
        {
            ContentType = "Piece";
            Display = "inline-block";
            Position = "relative";
            base.OnInitialized();
        }
    }
}