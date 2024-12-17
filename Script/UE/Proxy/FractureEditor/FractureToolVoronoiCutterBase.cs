using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureToolVoronoiCutterBase")]
	public partial class UFractureToolVoronoiCutterBase : UFractureToolCutterBase, IStaticClass
	{
		public TArray<ULineSetComponent> VoronoiLineSets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VoronoiLineSets, __ReturnBuffer);

					return *(TArray<ULineSetComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VoronoiLineSets, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureToolVoronoiCutterBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __VoronoiLineSets = 0;
	}
}