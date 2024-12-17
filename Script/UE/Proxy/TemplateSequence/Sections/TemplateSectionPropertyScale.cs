using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.TemplateSequence
{
	[PathName("/Script/TemplateSequence.TemplateSectionPropertyScale")]
	public partial class FTemplateSectionPropertyScale : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TemplateSequence.TemplateSectionPropertyScale");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTemplateSectionPropertyScale() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTemplateSectionPropertyScale() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTemplateSectionPropertyScale A, FTemplateSectionPropertyScale B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTemplateSectionPropertyScale A, FTemplateSectionPropertyScale B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTemplateSectionPropertyScale;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FGuid ObjectBinding
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ObjectBinding, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ObjectBinding, __InBuffer);
				}
			}
		}

		public FMovieScenePropertyBinding PropertyBinding
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PropertyBinding, __ReturnBuffer);

					return *(FMovieScenePropertyBinding*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PropertyBinding, __InBuffer);
				}
			}
		}

		public ETemplateSectionPropertyScaleType PropertyScaleType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PropertyScaleType, __ReturnBuffer);

					return *(ETemplateSectionPropertyScaleType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PropertyScaleType, __InBuffer);
				}
			}
		}

		public FMovieSceneFloatChannel FloatChannel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FloatChannel, __ReturnBuffer);

					return *(FMovieSceneFloatChannel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FloatChannel, __InBuffer);
				}
			}
		}

		private static uint __ObjectBinding = 0;

		private static uint __PropertyBinding = 0;

		private static uint __PropertyScaleType = 0;

		private static uint __FloatChannel = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}