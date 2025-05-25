using UnrealBuildTool;

public class BuyuKosusuEditorTarget : TargetRules
{
	public BuyuKosusuEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("BuyuKosusu");
	}
}
