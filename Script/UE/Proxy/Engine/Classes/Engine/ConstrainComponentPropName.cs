using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ConstrainComponentPropName")]
	public partial class FConstrainComponentPropName : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ConstrainComponentPropName");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FConstrainComponentPropName() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FConstrainComponentPropName() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FConstrainComponentPropName A, FConstrainComponentPropName B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FConstrainComponentPropName A, FConstrainComponentPropName B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FConstrainComponentPropName;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName ComponentName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ComponentName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ComponentName, __InBuffer);
				}
			}
		}

		private static uint __ComponentName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}