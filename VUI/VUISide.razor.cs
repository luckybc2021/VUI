using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Primitives;

namespace VUI
{
    public partial class VUISide<TPiece>
    {
        private string view = "";
        [Parameter]
        public string View 
        { 
            get => view;
            set
            {
                view = value;
            } 
        }

        [Parameter]
        public TPiece? Piece { get; set; }


        [Parameter]
        public RenderFragment<TPiece>? ChildContent { get; set; }        
    }
}