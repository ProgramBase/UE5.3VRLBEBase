using Script.CoreUObject;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureToolRecomputeNormals")]
	public partial class UFractureToolRecomputeNormals : UFractureToolCutterBase, IStaticClass
	{
		public UFractureRecomputeNormalsSettings NormalsSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NormalsSettings, __ReturnBuffer);

					return *(UFractureRecomputeNormalsSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NormalsSettings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureToolRecomputeNormals");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __NormalsSettings = 0;
	}
}