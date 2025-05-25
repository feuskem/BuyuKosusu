using UnrealBuildTool;

public class BuyuKosusuTarget : TargetRules
{
	public BuyuKosusuTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("BuyuKosusu");
	}
}
