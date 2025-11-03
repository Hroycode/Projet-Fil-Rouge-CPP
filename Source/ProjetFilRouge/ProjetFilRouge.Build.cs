// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ProjetFilRouge : ModuleRules
{
	public ProjetFilRouge(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"ProjetFilRouge",
			"ProjetFilRouge/Variant_Platforming",
			"ProjetFilRouge/Variant_Platforming/Animation",
			"ProjetFilRouge/Variant_Combat",
			"ProjetFilRouge/Variant_Combat/AI",
			"ProjetFilRouge/Variant_Combat/Animation",
			"ProjetFilRouge/Variant_Combat/Gameplay",
			"ProjetFilRouge/Variant_Combat/Interfaces",
			"ProjetFilRouge/Variant_Combat/UI",
			"ProjetFilRouge/Variant_SideScrolling",
			"ProjetFilRouge/Variant_SideScrolling/AI",
			"ProjetFilRouge/Variant_SideScrolling/Gameplay",
			"ProjetFilRouge/Variant_SideScrolling/Interfaces",
			"ProjetFilRouge/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
