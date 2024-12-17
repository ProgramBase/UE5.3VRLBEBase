using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.GizmoScaledTransformSource")]
	public partial class UGizmoScaledTransformSource : UGizmoBaseTransformSource, IStaticClass
	{
		public TScriptInterface<IGizmoTransformSource> ChildTransformSource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ChildTransformSource, __ReturnBuffer);

					return *(TScriptInterface<IGizmoTransformSource>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ChildTransformSource, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.GizmoScaledTransformSource");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ChildTransformSource = 0;
	}
}