using Script.CoreUObject;
using Script.Library;
using Script.InterchangeCore;

namespace Script.InterchangeEngine
{
	[PathName("/Script/InterchangeEngine.InterchangeTranslatorPipelines")]
	public partial class FInterchangeTranslatorPipelines : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/InterchangeEngine.InterchangeTranslatorPipelines");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInterchangeTranslatorPipelines() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInterchangeTranslatorPipelines() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInterchangeTranslatorPipelines A, FInterchangeTranslatorPipelines B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInterchangeTranslatorPipelines A, FInterchangeTranslatorPipelines B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInterchangeTranslatorPipelines;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSoftClassPtr<UInterchangeTranslatorBase> Translator
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Translator, __ReturnBuffer);

					return *(TSoftClassPtr<UInterchangeTranslatorBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Translator, __InBuffer);
				}
			}
		}

		public TArray<FSoftObjectPath> Pipelines
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Pipelines, __ReturnBuffer);

					return *(TArray<FSoftObjectPath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Pipelines, __InBuffer);
				}
			}
		}

		private static uint __Translator = 0;

		private static uint __Pipelines = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}