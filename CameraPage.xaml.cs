namespace MauiPetShop;

public partial class CameraPage : ContentPage
{
    private readonly IMediaPicker mediaPicker;

    public CameraPage()
    {
        InitializeComponent();
        this.mediaPicker = MauiProgram.CreateMauiApp().Services.GetService<IMediaPicker>();
    }

    public CameraPage(IMediaPicker mediaPicker)
    {
        InitializeComponent();
        this.mediaPicker = mediaPicker;
    }

    private async void OnCameraClickedAsync(object sender, EventArgs e)
    {
        if (mediaPicker.IsCaptureSupported)
        {
            FileResult photo = await mediaPicker.CapturePhotoAsync();


            if (photo != null)
            {
                image.Source = photo.FullPath;
                string localFilePath = Path.Combine(FileSystem.CacheDirectory, photo.FileName);

                using Stream source = await photo.OpenReadAsync();
                using FileStream localFile = File.OpenWrite(localFilePath);

                await source.CopyToAsync(localFile);
            }
        }
    }
}