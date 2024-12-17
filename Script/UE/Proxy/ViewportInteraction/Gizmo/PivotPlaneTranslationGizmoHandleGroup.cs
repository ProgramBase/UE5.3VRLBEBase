﻿using Script.CoreUObject;
using Script.Library;

namespace Script.ViewportInteraction
{
	[PathName("/Script/ViewportInteraction.PivotPlaneTranslationGizmoHandleGroup")]
	public partial class UPivotPlaneTranslationGizmoHandleGroup : UAxisGizmoHandleGroup, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ViewportInteraction.PivotPlaneTranslationGizmoHandleGroup");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}