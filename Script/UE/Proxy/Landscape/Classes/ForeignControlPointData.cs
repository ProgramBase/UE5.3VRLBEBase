using Script.CoreUObject;
using Script.Library;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.ForeignControlPointData")]
	public partial class FForeignControlPointData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Landscape.ForeignControlPointData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FForeignControlPointData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FForeignControlPointData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FForeignControlPointData A, FForeignControlPointData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FForeignControlPointData A, FForeignControlPointData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FForeignControlPointData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FGuid ModificationKey
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ModificationKey, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ModificationKey, __InBuffer);
				}
			}
		}

		public UControlPointMeshComponent MeshComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MeshComponent, __ReturnBuffer);

					return *(UControlPointMeshComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MeshComponent, __InBuffer);
				}
			}
		}

		public TLazyObjectPtr<ULandscapeSplineControlPoint> Identifier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Identifier, __ReturnBuffer);

					return *(TLazyObjectPtr<ULandscapeSplineControlPoint>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Identifier, __InBuffer);
				}
			}
		}

		private static uint __ModificationKey = 0;

		private static uint __MeshComponent = 0;

		private static uint __Identifier = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}