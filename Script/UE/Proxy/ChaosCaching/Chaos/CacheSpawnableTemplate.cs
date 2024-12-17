using Script.CoreUObject;
using Script.Library;

namespace Script.ChaosCaching
{
	[PathName("/Script/ChaosCaching.CacheSpawnableTemplate")]
	public partial class FCacheSpawnableTemplate : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ChaosCaching.CacheSpawnableTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCacheSpawnableTemplate() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCacheSpawnableTemplate() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCacheSpawnableTemplate A, FCacheSpawnableTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCacheSpawnableTemplate A, FCacheSpawnableTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCacheSpawnableTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UObject DuplicatedTemplate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DuplicatedTemplate, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DuplicatedTemplate, __InBuffer);
				}
			}
		}

		public FTransform InitialTransform
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InitialTransform, __ReturnBuffer);

					return *(FTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InitialTransform, __InBuffer);
				}
			}
		}

		public FTransform ComponentTransform
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ComponentTransform, __ReturnBuffer);

					return *(FTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ComponentTransform, __InBuffer);
				}
			}
		}

		private static uint __DuplicatedTemplate = 0;

		private static uint __InitialTransform = 0;

		private static uint __ComponentTransform = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}