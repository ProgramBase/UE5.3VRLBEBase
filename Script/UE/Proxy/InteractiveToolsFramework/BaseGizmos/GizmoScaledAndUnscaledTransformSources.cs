using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.GizmoScaledAndUnscaledTransformSources")]
	public partial class UGizmoScaledAndUnscaledTransformSources : UGizmoBaseTransformSource, IStaticClass
	{
		public TScriptInterface<IGizmoTransformSource> ScaledTransformSource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ScaledTransformSource, __ReturnBuffer);

					return *(TScriptInterface<IGizmoTransformSource>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ScaledTransformSource, __InBuffer);
				}
			}
		}

		public TScriptInterface<IGizmoTransformSource> UnscaledTransformSource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UnscaledTransformSource, __ReturnBuffer);

					return *(TScriptInterface<IGizmoTransformSource>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UnscaledTransformSource, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.GizmoScaledAndUnscaledTransformSources");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ScaledTransformSource = 0;

		private static uint __UnscaledTransformSource = 0;
	}
}