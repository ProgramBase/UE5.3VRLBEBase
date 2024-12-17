using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.TemplateSequence
{
	[PathName("/Script/TemplateSequence.TemplateSequenceSection")]
	public partial class UTemplateSequenceSection : UMovieSceneSubSection, IStaticClass
	{
		public TArray<FTemplateSectionPropertyScale> PropertyScales
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PropertyScales, __ReturnBuffer);

					return *(TArray<FTemplateSectionPropertyScale>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PropertyScales, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TemplateSequence.TemplateSequenceSection");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PropertyScales = 0;
	}
}