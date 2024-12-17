using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementRuntime
{
	[PathName("/Script/TypedElementRuntime.TypedElementSelectionNormalizationOptions")]
	public partial class FTypedElementSelectionNormalizationOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TypedElementRuntime.TypedElementSelectionNormalizationOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTypedElementSelectionNormalizationOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTypedElementSelectionNormalizationOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTypedElementSelectionNormalizationOptions A, FTypedElementSelectionNormalizationOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTypedElementSelectionNormalizationOptions A, FTypedElementSelectionNormalizationOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTypedElementSelectionNormalizationOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bExpandGroups
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bExpandGroups, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bExpandGroups, __InBuffer);
				}
			}
		}

		public bool bFollowAttachment
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bFollowAttachment, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bFollowAttachment, __InBuffer);
				}
			}
		}

		private static uint __bExpandGroups = 0;

		private static uint __bFollowAttachment = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}