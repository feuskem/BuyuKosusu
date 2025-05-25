using UnrealBuildTool;

public class BuyuKosusuServerTarget : TargetRules
{
	public BuyuKosusuServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("BuyuKosusu");
	}
}
