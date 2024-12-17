using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneCapture
{
	[PathName("/Script/MovieSceneCapture.CompositionGraphCapturePasses")]
	public partial class FCompositionGraphCapturePasses : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneCapture.CompositionGraphCapturePasses");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCompositionGraphCapturePasses() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCompositionGraphCapturePasses() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCompositionGraphCapturePasses A, FCompositionGraphCapturePasses B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCompositionGraphCapturePasses A, FCompositionGraphCapturePasses B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCompositionGraphCapturePasses;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FString> Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

		private static uint __Value = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}