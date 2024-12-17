using Script.CoreUObject;
using Script.Library;

namespace Script.Localization
{
	[PathName("/Script/Localization.GatherTextFileExtension")]
	public partial class FGatherTextFileExtension : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Localization.GatherTextFileExtension");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGatherTextFileExtension() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGatherTextFileExtension() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGatherTextFileExtension A, FGatherTextFileExtension B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGatherTextFileExtension A, FGatherTextFileExtension B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGatherTextFileExtension;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString Pattern
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Pattern, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Pattern, __InBuffer);
				}
			}
		}

		private static uint __Pattern = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}