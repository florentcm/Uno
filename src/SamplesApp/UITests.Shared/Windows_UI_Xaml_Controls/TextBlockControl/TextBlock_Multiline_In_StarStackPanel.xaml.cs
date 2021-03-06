using Uno.UI.Samples.Controls;
using Uno.UI.Samples.Presentation.SamplePages;
using Windows.UI.Xaml.Controls;

namespace Uno.UI.Samples.Content.UITests.TextBlockControl
{
	[SampleControlInfoAttribute("TextBlockControl", "TextBlock_Multiline_In_StarStackPanel", typeof(TextBlockViewModel), description: "A multiline textblock that contains data-bound runs that should wrap properly.")]
	public sealed partial class TextBlock_Multiline_In_StarStackPanel : UserControl
	{
		public TextBlock_Multiline_In_StarStackPanel()
		{
			this.InitializeComponent();
		}
	}
}
