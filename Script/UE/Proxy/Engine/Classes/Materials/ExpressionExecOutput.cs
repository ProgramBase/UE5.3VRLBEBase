using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ExpressionExecOutput")]
	public partial class FExpressionExecOutput : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ExpressionExecOutput");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FExpressionExecOutput() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FExpressionExecOutput() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FExpressionExecOutput A, FExpressionExecOutput B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FExpressionExecOutput A, FExpressionExecOutput B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FExpressionExecOutput;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UMaterialExpression Expression
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Expression, __ReturnBuffer);

					return *(UMaterialExpression*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Expression, __InBuffer);
				}
			}
		}

		private static uint __Expression = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}