using Microsoft.AspNetCore.Components;

namespace VUI
{
    public partial class VUIPaper<TPiece>
    {
        RenderFragment<TPiece>? CurrentPage { get; set; } = default;

        [Parameter]
        public RenderFragment<TPiece>? Page1 { get; set; } = default;

        [Parameter]
        public RenderFragment<TPiece>? Page2 { get; set; } = default;


        [Parameter, EditorRequired]
        public IReadOnlyList<TPiece>? Pieces { get; set; } = default;

        private int pageNumber = 0;
        [Parameter]
        public int PageNumber
        {
            get => pageNumber;
            set { pageNumber = value; }
        }

        private int pieceNumber = -1;
        private int _pieceNumber = -1;
        [Parameter]
        public int PieceNumber
        {
            get => _pieceNumber;
            set { _pieceNumber = value; }
        }

        private int nextPieceNumber = -1;
        private int _nextPieceNumber = -1;
        [Parameter]
        public int NextPieceNumber
        {
            get => _nextPieceNumber;
            set { _nextPieceNumber = value; }
        }

        protected override void OnInitialized()
        {
            CurrentPage = Page1;
            ContentType = "Paper";
            Width = "100vw";
            Height = "100vh";
            Display = "block";
            Position = "relative";
            OverFlow = "auto";
            base.OnInitialized();
        }

        protected override void OnParametersSet()
        {
            Handle_View();
            

            if (Pieces != null && Pieces.Count > 0)
            {
                if (PieceNumber == -1)
                {
                    pieceNumber = -1;
                }
                else
                {
                    if (PieceNumber < 1)
                    {
                        PieceNumber = 1;
                        pieceNumber = 0;
                    }
                    else
                    {
                        if (PieceNumber > Pieces.Count)
                            PieceNumber = Pieces.Count;

                        pieceNumber = PieceNumber - 1;
                    }
                }

                if (NextPieceNumber == -1)
                {
                    nextPieceNumber = -1;
                }
                else
                {
                    if (NextPieceNumber < 1)
                    {
                        NextPieceNumber = 1;
                        nextPieceNumber = 0;
                    }
                    else
                    {
                        if (NextPieceNumber > Pieces.Count)
                            NextPieceNumber = Pieces.Count;

                        nextPieceNumber = NextPieceNumber - 1;
                    }
                }
            }

            
            if (PageNumber <= 1)
            {
                PageNumber = 1;
                CurrentPage = Page1;
            }
            else if (PageNumber >= 2)
            {
                PageNumber = 2;
                CurrentPage = Page2;
            }

            StateHasChanged();
        }
    }
}