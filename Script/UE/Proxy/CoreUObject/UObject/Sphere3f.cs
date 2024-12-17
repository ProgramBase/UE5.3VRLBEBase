using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.Sphere3f")]
	public partial class FSphere3f : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.Sphere3f");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSphere3f() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSphere3f() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSphere3f A, FSphere3f B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSphere3f A, FSphere3f B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSphere3f;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FVector3f Center
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Center, __ReturnBuffer);

					return *(FVector3f*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Center, __InBuffer);
				}
			}
		}

		public float W
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __W, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __W, __InBuffer);
				}
			}
		}

		private static uint __Center = 0;

		private static uint __W = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}