using System;
using ReactiveUI;
using UIKit;

namespace ReactiveUILinker
{
	public partial class ViewController : ReactiveViewController, IViewFor<ViewModel>
	{
		private ViewModel _viewModel;
		public ViewModel ViewModel
		{
			get { return _viewModel; }
			set { this.RaiseAndSetIfChanged(ref _viewModel, value); }
		}

		object IViewFor.ViewModel
		{
			get { return ViewModel; }
			set { ViewModel = (ViewModel)value; }
		}

		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			ViewModel = new ViewModel();

			this.OneWayBind(ViewModel, vm => vm.HideButton, v => v.MyButton.Hidden); // Throws an exception when linker is enabled

			//MyButton.Hidden = false;
			ViewModel.HideButton = false;
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
