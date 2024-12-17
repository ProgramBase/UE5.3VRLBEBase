using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryFramework
{
	[PathName("/Script/GeometryFramework.DynamicMeshChangeInfo")]
	public partial class FDynamicMeshChangeInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryFramework.DynamicMeshChangeInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDynamicMeshChangeInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDynamicMeshChangeInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDynamicMeshChangeInfo A, FDynamicMeshChangeInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDynamicMeshChangeInfo A, FDynamicMeshChangeInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDynamicMeshChangeInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EDynamicMeshChangeType Type
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Type, __ReturnBuffer);

					return *(EDynamicMeshChangeType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Type, __InBuffer);
				}
			}
		}

		public EDynamicMeshAttributeChangeFlags Flags
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Flags, __ReturnBuffer);

					return *(EDynamicMeshAttributeChangeFlags*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Flags, __InBuffer);
				}
			}
		}

		public bool bIsRevertChange
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsRevertChange, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsRevertChange, __InBuffer);
				}
			}
		}

		private static uint __Type = 0;

		private static uint __Flags = 0;

		private static uint __bIsRevertChange = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}