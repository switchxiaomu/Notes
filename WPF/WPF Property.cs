public class WPF{
    //是否使用默认样式，如果将OverridesDefaultStyle设置为true，将不使用默认样式。
    public bool OverridesDefaultStyle { get; set; } = false;
    //该值确定在呈现过程中，此元素的呈现是否应使用特定于设备的像素设置。如果将SnapsToDevicePixels设置为true，将减少锯齿。
    public bool SnapsToDevicePixels { get; set; } = false;
}