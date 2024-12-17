﻿using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.SequencerAnimTools
{
	[PathName("/Script/SequencerAnimTools.MotionTrailToolBuilder")]
	public partial class UMotionTrailToolBuilder : UInteractiveToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SequencerAnimTools.MotionTrailToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}