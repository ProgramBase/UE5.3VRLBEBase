using Script.CoreUObject;
using Script.Library;

namespace Script.FieldSystemEngine
{
	[PathName("/Script/FieldSystemEngine.FieldObjectCommands")]
	public partial class FFieldObjectCommands : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/FieldSystemEngine.FieldObjectCommands");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFieldObjectCommands() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FFieldObjectCommands() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FFieldObjectCommands A, FFieldObjectCommands B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFieldObjectCommands A, FFieldObjectCommands B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFieldObjectCommands;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FName> TargetNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TargetNames, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TargetNames, __InBuffer);
				}
			}
		}

		public TArray<UFieldNodeBase> RootNodes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RootNodes, __ReturnBuffer);

					return *(TArray<UFieldNodeBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RootNodes, __InBuffer);
				}
			}
		}

		public TArray<UFieldSystemMetaData> MetaDatas
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MetaDatas, __ReturnBuffer);

					return *(TArray<UFieldSystemMetaData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MetaDatas, __InBuffer);
				}
			}
		}

		private static uint __TargetNames = 0;

		private static uint __RootNodes = 0;

		private static uint __MetaDatas = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}