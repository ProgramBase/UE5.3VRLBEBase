using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EnvDirection")]
	public partial class FEnvDirection : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AIModule.EnvDirection");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEnvDirection() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEnvDirection() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEnvDirection A, FEnvDirection B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEnvDirection A, FEnvDirection B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEnvDirection;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSubclassOf<UEnvQueryContext> LineFrom
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LineFrom, __ReturnBuffer);

					return *(TSubclassOf<UEnvQueryContext>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LineFrom, __InBuffer);
				}
			}
		}

		public TSubclassOf<UEnvQueryContext> LineTo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LineTo, __ReturnBuffer);

					return *(TSubclassOf<UEnvQueryContext>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LineTo, __InBuffer);
				}
			}
		}

		public TSubclassOf<UEnvQueryContext> Rotation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Rotation, __ReturnBuffer);

					return *(TSubclassOf<UEnvQueryContext>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Rotation, __InBuffer);
				}
			}
		}

		public EEnvDirection DirMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DirMode, __ReturnBuffer);

					return *(EEnvDirection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DirMode, __InBuffer);
				}
			}
		}

		private static uint __LineFrom = 0;

		private static uint __LineTo = 0;

		private static uint __Rotation = 0;

		private static uint __DirMode = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}