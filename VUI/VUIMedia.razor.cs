using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace VUI
{
    public partial class VUIMedia
    {
        private static int mediaCounting = 0;
        private static string digitSeparator = "";


        string mediaID = "";
        [Parameter]
        public string MediaID
        {
            get => mediaID;
            set { mediaID = value; }
        }

        protected string NewMediaID()
        {
            if (string.IsNullOrEmpty(mediaID))
            {
                if (mediaCounting + 1 >= int.MaxValue)
                {
                    digitSeparator += "_";
                    mediaCounting = 0;
                }

                mediaID = $"MediaID{digitSeparator}{mediaCounting++}";
            }

            return mediaID;
        }


        public void SetMediaID(string value)
        {
            MediaID = value;
        }

        protected override void OnInitialized()
        {
            MediaID = NewMediaID();
            Transition = "None";

            base.OnInitialized();
        }

        /// <summary>
        /// Resets the media counter and digit separator. 
        /// This function should be invoked prior to navigating to a page that 
        /// contains a VUIElement with a media ContentType, such as 'Music' or 'Video'.
        /// </summary>
        public static void ResetMediaCounting()
        {
            mediaCounting = 0;
            digitSeparator = "";
        }


        public override async Task Play()
        {
            await JSRuntime.InvokeVoidAsync("playMedia", MediaID);
        }

        public override async Task Pause()
        {
            await JSRuntime.InvokeVoidAsync("pauseMedia", MediaID);
        }

        internal override async Task LoadDetails()
        {
            switch (ContentType)
            {
                case "Audio":
                case "Video":

                    Duration = await JSRuntime.InvokeAsync<double>(
                        "getMediaDuration", MediaID);

                    break;
            }
        }

        public override async Task<double> GetCurrentTime()
        {
            switch (ContentType)
            {
                case "Audio":
                case "Video":

                    CurrentTime = await JSRuntime.InvokeAsync<double>(
                        "getMediaCurrentTime", MediaID);
                    break;
            }

            return CurrentTime;
        }

        public override async Task SetCurrentTime(double _t)
        {
            switch (ContentType)
            {
                case "Audio":
                case "Video":

                    await JSRuntime.InvokeVoidAsync(
                        "setMediaCurrentTime", MediaID, _t);
                    break;
            }
        }

        public override async Task<double> GetPlaybackRate()
        {
            switch (ContentType)
            {
                case "Audio":
                case "Video":

                    PlaybackRate = await JSRuntime.InvokeAsync<double>(
                        "getPlaybackRate", MediaID);
                    break;
            }

            return PlaybackRate;
        }

        public override async Task SetPlaybackRate(double _t)
        {
            switch (ContentType)
            {
                case "Audio":
                case "Video":

                    await JSRuntime.InvokeVoidAsync(
                        "setPlaybackRate", MediaID, _t);
                    break;
            }
        }
    }
}