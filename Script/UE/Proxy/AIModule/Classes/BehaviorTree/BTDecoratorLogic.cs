using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BTDecoratorLogic")]
	public partial class FBTDecoratorLogic : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AIModule.BTDecoratorLogic");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBTDecoratorLogic() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBTDecoratorLogic() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBTDecoratorLogic A, FBTDecoratorLogic B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBTDecoratorLogic A, FBTDecoratorLogic B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBTDecoratorLogic;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EBTDecoratorLogic Operation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Operation, __ReturnBuffer);

					return *(EBTDecoratorLogic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Operation, __InBuffer);
				}
			}
		}

		public ushort Number
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[2];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Number, __ReturnBuffer);

					return *(ushort*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[2];

					*(ushort*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Number, __InBuffer);
				}
			}
		}

		private static uint __Operation = 0;

		private static uint __Number = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}