using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.Matrix")]
	public partial class FMatrix : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.Matrix");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMatrix() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMatrix() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMatrix A, FMatrix B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMatrix A, FMatrix B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMatrix;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FPlane XPlane
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __XPlane, __ReturnBuffer);

					return *(FPlane*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __XPlane, __InBuffer);
				}
			}
		}

		public FPlane YPlane
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __YPlane, __ReturnBuffer);

					return *(FPlane*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __YPlane, __InBuffer);
				}
			}
		}

		public FPlane ZPlane
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ZPlane, __ReturnBuffer);

					return *(FPlane*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ZPlane, __InBuffer);
				}
			}
		}

		public FPlane WPlane
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WPlane, __ReturnBuffer);

					return *(FPlane*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WPlane, __InBuffer);
				}
			}
		}

		private static uint __XPlane = 0;

		private static uint __YPlane = 0;

		private static uint __ZPlane = 0;

		private static uint __WPlane = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}