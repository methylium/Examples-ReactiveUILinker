using System;
using ReactiveUI;

namespace ReactiveUILinker
{
	public class ViewModel : ReactiveObject
	{
		private bool _hideButton = true;
		public bool HideButton
		{ 
			get { return _hideButton; }
			set { this.RaiseAndSetIfChanged(ref _hideButton, value); }
		}
	}
}
