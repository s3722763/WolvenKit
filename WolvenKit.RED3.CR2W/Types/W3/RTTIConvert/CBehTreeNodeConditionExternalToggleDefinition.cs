using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeConditionExternalToggleDefinition : CBehTreeNodeConditionDefinition
	{
		[Ordinal(1)] [RED("switchName")] 		public CName SwitchName { get; set;}

		[Ordinal(2)] [RED("initialValue")] 		public CBehTreeValBool InitialValue { get; set;}

		public CBehTreeNodeConditionExternalToggleDefinition(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}