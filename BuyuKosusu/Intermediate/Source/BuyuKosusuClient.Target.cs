using UnrealBuildTool;

public class BuyuKosusuClientTarget : TargetRules
{
	public BuyuKosusuClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("BuyuKosusu");
	}
}
