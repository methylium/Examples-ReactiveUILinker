using System;
using UIKit;

namespace ReactiveUILinker
{
	public class LinkerPreserve
	{
		static LinkerPreserve()
		{
			try
			{
				default(UIButton).Hidden = default(bool);
			}
			catch (Exception)
			{
				throw new Exception("Don't call this class");
			}
		}
	}
}
