using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VUI
{
    public partial class VUIPaper<TPiece> : VUIElement
    {
        private string[] view = { "single", "", "" };

        private string _view = "single";
        [Parameter]
        public string View
        {
            get => _view;
            set
            {
                _view = value;
            }
        }

        private void Handle_View()
        {
            var parts = View.Split(' ',
                StringSplitOptions.RemoveEmptyEntries);

            switch (parts.Length)
            {
                case 1:
                    
                    _one(parts);

                    Display = "block";
                    FlexFlow = "unset";
                    Width = "100%";
                    Height = "100vh";
                    break;

                case 2:

                    _one(parts);
                    _two(parts);

                    Display = "inline-block";
                    FlexFlow = "unset";
                    Width = "100%";
                    Height = "100vh";
                    break;

                case 3:

                    _one(parts);
                    _two(parts);
                    _three(parts);
                    break;
            }
        }

        private void _one(string[] parts)
        {
            switch (parts[0])
            {
                case "dual":

                    view[0] = "dual";
                    view[1] = "vertical-fit";
                    view[2] = "vertical-fit";

                    break;

                case "single":
                default:

                    View = "single";
                    view[0] = "single";
                    view[1] = "";
                    view[2] = "";
                    break;
            }
        }

        private void _two(string[] parts)
        {
            switch (parts[1])
            {
                case "horizontal":

                    view[1] = "horizontal-fit";
                    view[2] = "horizontal-fit";
                    break;

                default:

                    View = "dual vertical fit";
                    break;
            }
        }

        private void _three(string[] parts)
        {
            switch (parts[1])
            {
                case "horizontal":

                    _horizontal(parts);

                    break;

                default:

                    _vertical(parts);
                    break;
            }            
        }

        private void _horizontal(string[] parts)
        {
            switch (parts[2])
            {
                case "max":

                    view[1] = "horizontal-max";
                    view[2] = "horizontal-max";

                    Display = "inline-flex";
                    FlexFlow = "row";
                    Width = "max-content";
                    Height = "100vh";
                    break;

                case "normal":

                    view[1] = "horizontal-normal";
                    view[2] = "horizontal-normal";

                    Display = "inline-flex";
                    FlexFlow = "column";
                    Width = "100vw";
                    Height = "100vh";
                    break;

                default :

                    view[1] = "horizontal-fit";
                    view[2] = "horizontal-fit";

                    Display = "inline-block";
                    FlexFlow = "unset";
                    Width = "100%";
                    Height = "100vh";
                    break;
            }
        }

        private void _vertical(string[] parts)
        {
            switch (parts[2])
            {
                case "max":

                    view[1] = "vertical-max";
                    view[2] = "vertical-max";

                    Display = "block";
                    FlexFlow = "unset";
                    Width = "100%";
                    Height = "max-content";
                    break;

                case "normal":

                    view[1] = "vertical-normal";
                    view[2] = "vertical-normal";

                    Display = "inline-block";
                    FlexFlow = "unset";
                    Width = "100vw";
                    Height = "100vh";
                    break;

                default:
                    view[1] = "vertical-fit";
                    view[2] = "vertical-fit";

                    Display = "block";
                    FlexFlow = "unset";
                    Width = "100%";
                    Height = "100vh";
                    break;
            }
        }
    }
}
