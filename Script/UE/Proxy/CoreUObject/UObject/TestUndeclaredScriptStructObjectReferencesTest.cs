using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.TestUndeclaredScriptStructObjectReferencesTest")]
	public partial class FTestUndeclaredScriptStructObjectReferencesTest : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.TestUndeclaredScriptStructObjectReferencesTest");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTestUndeclaredScriptStructObjectReferencesTest() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTestUndeclaredScriptStructObjectReferencesTest() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTestUndeclaredScriptStructObjectReferencesTest A, FTestUndeclaredScriptStructObjectReferencesTest B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTestUndeclaredScriptStructObjectReferencesTest A, FTestUndeclaredScriptStructObjectReferencesTest B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTestUndeclaredScriptStructObjectReferencesTest;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UObject StrongObjectPointer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StrongObjectPointer, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StrongObjectPointer, __InBuffer);
				}
			}
		}

		public TSoftObjectPtr<UObject> SoftObjectPointer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SoftObjectPointer, __ReturnBuffer);

					return *(TSoftObjectPtr<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SoftObjectPointer, __InBuffer);
				}
			}
		}

		public FSoftObjectPath SoftObjectPath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SoftObjectPath, __ReturnBuffer);

					return *(FSoftObjectPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SoftObjectPath, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<UObject> WeakObjectPointer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WeakObjectPointer, __ReturnBuffer);

					return *(TWeakObjectPtr<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WeakObjectPointer, __InBuffer);
				}
			}
		}

		private static uint __StrongObjectPointer = 0;

		private static uint __SoftObjectPointer = 0;

		private static uint __SoftObjectPath = 0;

		private static uint __WeakObjectPointer = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}