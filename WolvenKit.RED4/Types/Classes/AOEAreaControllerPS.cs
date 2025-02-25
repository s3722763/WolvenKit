using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AOEAreaControllerPS : MasterControllerPS
	{
		[Ordinal(105)] 
		[RED("AOEAreaSetup")] 
		public AOEAreaSetup AOEAreaSetup
		{
			get => GetPropertyValue<AOEAreaSetup>();
			set => SetPropertyValue<AOEAreaSetup>(value);
		}

		public AOEAreaControllerPS()
		{
			DeviceName = "LocKey#188";
			TweakDBRecord = 69554440257;
			TweakDBDescriptionRecord = 121659857626;
			AOEAreaSetup = new() { Duration = -1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
