// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UnrealNGGMCPExample : ModuleRules
{
	public UnrealNGGMCPExample(ReadOnlyTargetRules Target) : base(Target)
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
			"UnrealNGGMCPExample",
			"UnrealNGGMCPExample/Variant_Platforming",
			"UnrealNGGMCPExample/Variant_Platforming/Animation",
			"UnrealNGGMCPExample/Variant_Combat",
			"UnrealNGGMCPExample/Variant_Combat/AI",
			"UnrealNGGMCPExample/Variant_Combat/Animation",
			"UnrealNGGMCPExample/Variant_Combat/Gameplay",
			"UnrealNGGMCPExample/Variant_Combat/Interfaces",
			"UnrealNGGMCPExample/Variant_Combat/UI",
			"UnrealNGGMCPExample/Variant_SideScrolling",
			"UnrealNGGMCPExample/Variant_SideScrolling/AI",
			"UnrealNGGMCPExample/Variant_SideScrolling/Gameplay",
			"UnrealNGGMCPExample/Variant_SideScrolling/Interfaces",
			"UnrealNGGMCPExample/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
