//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Framework.DataAccessGateway.Automation.DAGUnitTest
{
	using System;
	using System.Data;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using Framework.DataAccessGateway.Core;
	
	
	public class SubTable_Key
	{
		
		[Required()]
		[DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
		[DBHandlerProperty(Framework.DataAccessGateway.Core.DBHandlerDataType.Int, System.Data.ParameterDirection.ReturnValue)]
		public int Id { get; set; }
	}
	
	public class SubTable
	{
		
		[Required()]
		[DBHandlerProperty(Framework.DataAccessGateway.Core.DBHandlerDataType.Int, System.Data.ParameterDirection.ReturnValue)]
		public int Id { get; set; }
		
		[Required()]
		[DBHandlerProperty(Framework.DataAccessGateway.Core.DBHandlerDataType.BigInt, System.Data.ParameterDirection.Input)]
		public long BigInt { get; set; }
		
		[Required()]
		[DBHandlerProperty(Framework.DataAccessGateway.Core.DBHandlerDataType.UniqueIdentifier, System.Data.ParameterDirection.Input)]
		public System.Guid Data_Id { get; set; }
	}
	
	public class SubTable_Ext
	{
		
		[Required()]
		[DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
		[DBHandlerProperty(Framework.DataAccessGateway.Core.DBHandlerDataType.Int, System.Data.ParameterDirection.ReturnValue)]
		public int _Id { get; set; }
		
		[Required()]
		[DBHandlerProperty(Framework.DataAccessGateway.Core.DBHandlerDataType.Int, System.Data.ParameterDirection.ReturnValue)]
		public int Id { get; set; }
		
		[Required()]
		[DBHandlerProperty(Framework.DataAccessGateway.Core.DBHandlerDataType.BigInt, System.Data.ParameterDirection.Input)]
		public long BigInt { get; set; }
		
		[Required()]
		[DBHandlerProperty(Framework.DataAccessGateway.Core.DBHandlerDataType.UniqueIdentifier, System.Data.ParameterDirection.Input)]
		public System.Guid Data_Id { get; set; }
	}
}

