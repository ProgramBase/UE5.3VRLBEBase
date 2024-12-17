using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CameraShakeStartParams")]
	public partial class FCameraShakeStartParams : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.CameraShakeStartParams");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCameraShakeStartParams() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCameraShakeStartParams() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCameraShakeStartParams A, FCameraShakeStartParams B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCameraShakeStartParams A, FCameraShakeStartParams B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCameraShakeStartParams;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bIsRestarting
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsRestarting, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsRestarting, __InBuffer);
				}
			}
		}

		private static uint __bIsRestarting = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}