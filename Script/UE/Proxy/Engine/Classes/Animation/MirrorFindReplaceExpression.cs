using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MirrorFindReplaceExpression")]
	public partial class FMirrorFindReplaceExpression : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.MirrorFindReplaceExpression");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMirrorFindReplaceExpression() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMirrorFindReplaceExpression() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMirrorFindReplaceExpression A, FMirrorFindReplaceExpression B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMirrorFindReplaceExpression A, FMirrorFindReplaceExpression B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMirrorFindReplaceExpression;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName FindExpression
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FindExpression, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FindExpression, __InBuffer);
				}
			}
		}

		public FName ReplaceExpression
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ReplaceExpression, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ReplaceExpression, __InBuffer);
				}
			}
		}

		public EMirrorFindReplaceMethod FindReplaceMethod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FindReplaceMethod, __ReturnBuffer);

					return *(EMirrorFindReplaceMethod*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FindReplaceMethod, __InBuffer);
				}
			}
		}

		private static uint __FindExpression = 0;

		private static uint __ReplaceExpression = 0;

		private static uint __FindReplaceMethod = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}