namespace __4_DAL_CRM
{
    /// <summary>
    /// Target objective for a user or a team for a specified time period.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("goal")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Goal : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Goal() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "goal";

        public const int EntityTypeCode = 9600;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        private void OnPropertyChanged(string propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        private void OnPropertyChanging(string propertyName)
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
            }
        }

        /// <summary>
        /// Shows the actual value (Decimal type) achieved towards the target as of the last rolled-up date. This field appears when the metric type of the goal is Amount and the amount data type is Decimal.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualdecimal")]
        public System.Nullable<decimal> ActualDecimal
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("actualdecimal"); }
            set
            {
                this.OnPropertyChanging("ActualDecimal");
                this.SetAttributeValue("actualdecimal", value);
                this.OnPropertyChanged("ActualDecimal");
            }
        }

        /// <summary>
        /// Shows the actual value (integer) achieved towards the target as of the last rolled-up date. This field appears when the metric type of the goal is Amount or Count and the amount data type is Integer.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualinteger")]
        public System.Nullable<int> ActualInteger
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("actualinteger"); }
            set
            {
                this.OnPropertyChanging("ActualInteger");
                this.SetAttributeValue("actualinteger", value);
                this.OnPropertyChanged("ActualInteger");
            }
        }

        /// <summary>
        /// Shows the actual value (Money type) achieved towards the target as of the last rolled-up date. This field appears when the metric type of the goal is Amount and the amount data type is Money.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualmoney")]
        public Microsoft.Xrm.Sdk.Money ActualMoney
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("actualmoney"); }
            set
            {
                this.OnPropertyChanging("ActualMoney");
                this.SetAttributeValue("actualmoney", value);
                this.OnPropertyChanged("ActualMoney");
            }
        }

        /// <summary>
        /// Shows the actual value (money type) in base currency to track goal results against the target.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualmoney_base")]
        public Microsoft.Xrm.Sdk.Money ActualMoney_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("actualmoney_base"); }
        }

        /// <summary>
        /// Actual Value of the goal.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualstring")]
        public string ActualString
        {
            get { return this.GetAttributeValue<string>("actualstring"); }
        }

        /// <summary>
        /// Data type of the amount.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("amountdatatype")]
        public Microsoft.Xrm.Sdk.OptionSetValue AmountDataType
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("amountdatatype"); }
            set
            {
                this.OnPropertyChanging("AmountDataType");
                this.SetAttributeValue("amountdatatype", value);
                this.OnPropertyChanged("AmountDataType");
            }
        }

        /// <summary>
        /// Shows the expected amount for actual value (decimal type) against the target goal.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("computedtargetasoftodaydecimal")]
        public System.Nullable<decimal> ComputedTargetAsOfTodayDecimal
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("computedtargetasoftodaydecimal"); }
        }

        /// <summary>
        /// Shows the expected amount for actual value (integer type) against the target goal as of the current date.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("computedtargetasoftodayinteger")]
        public System.Nullable<int> ComputedTargetAsOfTodayInteger
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("computedtargetasoftodayinteger"); }
        }

        /// <summary>
        /// Shows the expected amount for actual value (money type) against the target goal as of the current date.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("computedtargetasoftodaymoney")]
        public Microsoft.Xrm.Sdk.Money ComputedTargetAsOfTodayMoney
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("computedtargetasoftodaymoney"); }
        }

        /// <summary>
        /// Shows the expected amount in base currency for actual value (money type) against the target goal as of the current date.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("computedtargetasoftodaymoney_base")]
        public Microsoft.Xrm.Sdk.Money ComputedTargetAsOfTodayMoney_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("computedtargetasoftodaymoney_base"); }
        }

        /// <summary>
        /// Shows the expected value for percentage achieved against the target goal as of the current date.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("computedtargetasoftodaypercentageachieved")]
        public System.Nullable<decimal> ComputedTargetAsOfTodayPercentageAchieved
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("computedtargetasoftodaypercentageachieved"); }
        }

        /// <summary>
        /// Select whether only the goal owner's records, or all records, should be rolled up for goal results.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("consideronlygoalownersrecords")]
        public System.Nullable<bool> ConsiderOnlyGoalOwnersRecords
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("consideronlygoalownersrecords"); }
            set
            {
                this.OnPropertyChanging("ConsiderOnlyGoalOwnersRecords");
                this.SetAttributeValue("consideronlygoalownersrecords", value);
                this.OnPropertyChanged("ConsiderOnlyGoalOwnersRecords");
            }
        }

        /// <summary>
        /// Shows who created the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Shows who created the record on behalf of another user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Indicates a placeholder rollup field for a decimal value to track a third category of results other than actuals and in-progress results.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customrollupfielddecimal")]
        public System.Nullable<decimal> CustomRollupFieldDecimal
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("customrollupfielddecimal"); }
            set
            {
                this.OnPropertyChanging("CustomRollupFieldDecimal");
                this.SetAttributeValue("customrollupfielddecimal", value);
                this.OnPropertyChanged("CustomRollupFieldDecimal");
            }
        }

        /// <summary>
        /// Indicates a placeholder rollup field for an integer value to track a third category of results other than actuals and in-progress results.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customrollupfieldinteger")]
        public System.Nullable<int> CustomRollupFieldInteger
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("customrollupfieldinteger"); }
            set
            {
                this.OnPropertyChanging("CustomRollupFieldInteger");
                this.SetAttributeValue("customrollupfieldinteger", value);
                this.OnPropertyChanged("CustomRollupFieldInteger");
            }
        }

        /// <summary>
        /// Indicates a placeholder rollup field for a money value to track a third category of results other than actuals and in-progress results.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customrollupfieldmoney")]
        public Microsoft.Xrm.Sdk.Money CustomRollupFieldMoney
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("customrollupfieldmoney"); }
            set
            {
                this.OnPropertyChanging("CustomRollupFieldMoney");
                this.SetAttributeValue("customrollupfieldmoney", value);
                this.OnPropertyChanged("CustomRollupFieldMoney");
            }
        }

        /// <summary>
        /// Indicates a placeholder rollup field for a money value in base currency to track a third category of results other than actuals and in-progress results.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customrollupfieldmoney_base")]
        public Microsoft.Xrm.Sdk.Money CustomRollupFieldMoney_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("customrollupfieldmoney_base"); }
        }

        /// <summary>
        /// Placeholder rollup field for the goal.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customrollupfieldstring")]
        public string CustomRollupFieldString
        {
            get { return this.GetAttributeValue<string>("customrollupfieldstring"); }
        }

        /// <summary>
        /// Depth of the goal in the tree.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("depth")]
        public System.Nullable<int> Depth
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("depth"); }
        }

        /// <summary>
        /// The default image for the entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage")]
        public byte[] EntityImage
        {
            get { return this.GetAttributeValue<byte[]>("entityimage"); }
            set
            {
                this.OnPropertyChanging("EntityImage");
                this.SetAttributeValue("entityimage", value);
                this.OnPropertyChanged("EntityImage");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_timestamp")]
        public System.Nullable<long> EntityImage_Timestamp
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("entityimage_timestamp"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_url")]
        public string EntityImage_URL
        {
            get { return this.GetAttributeValue<string>("entityimage_url"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimageid")]
        public System.Nullable<System.Guid> EntityImageId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("entityimageid"); }
        }

        /// <summary>
        /// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
        }

        /// <summary>
        /// Select the fiscal period for the goal.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fiscalperiod")]
        public Microsoft.Xrm.Sdk.OptionSetValue FiscalPeriod
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("fiscalperiod"); }
            set
            {
                this.OnPropertyChanging("FiscalPeriod");
                this.SetAttributeValue("fiscalperiod", value);
                this.OnPropertyChanged("FiscalPeriod");
            }
        }

        /// <summary>
        /// Select the fiscal year for the goal that's being tracked.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fiscalyear")]
        public Microsoft.Xrm.Sdk.OptionSetValue FiscalYear
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("fiscalyear"); }
            set
            {
                this.OnPropertyChanging("FiscalYear");
                this.SetAttributeValue("fiscalyear", value);
                this.OnPropertyChanged("FiscalYear");
            }
        }

        /// <summary>
        /// Enter the date when the goal ends.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("goalenddate")]
        public System.Nullable<System.DateTime> GoalEndDate
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("goalenddate"); }
            set
            {
                this.OnPropertyChanging("GoalEndDate");
                this.SetAttributeValue("goalenddate", value);
                this.OnPropertyChanged("GoalEndDate");
            }
        }

        /// <summary>
        /// Unique identifier of the goal.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("goalid")]
        public System.Nullable<System.Guid> GoalId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("goalid"); }
            set
            {
                this.OnPropertyChanging("GoalId");
                this.SetAttributeValue("goalid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("GoalId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("goalid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.GoalId = value; }
        }

        /// <summary>
        /// Choose the user or team responsible for meeting the goal.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("goalownerid")]
        public Microsoft.Xrm.Sdk.EntityReference GoalOwnerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("goalownerid"); }
            set
            {
                this.OnPropertyChanging("GoalOwnerId");
                this.SetAttributeValue("goalownerid", value);
                this.OnPropertyChanged("GoalOwnerId");
            }
        }

        /// <summary>
        /// Enter the date and time when the period for tracking the goal begins.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("goalstartdate")]
        public System.Nullable<System.DateTime> GoalStartDate
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("goalstartdate"); }
            set
            {
                this.OnPropertyChanging("GoalStartDate");
                this.SetAttributeValue("goalstartdate", value);
                this.OnPropertyChanged("GoalStartDate");
            }
        }

        /// <summary>
        /// Unique identifier of the goal that caused an error in the rollup of the goal hierarchy.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("goalwitherrorid")]
        public Microsoft.Xrm.Sdk.EntityReference GoalWithErrorId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("goalwitherrorid"); }
            set
            {
                this.OnPropertyChanging("GoalWithErrorId");
                this.SetAttributeValue("goalwitherrorid", value);
                this.OnPropertyChanged("GoalWithErrorId");
            }
        }

        /// <summary>
        /// Sequence number of the import that created this record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
        public System.Nullable<int> ImportSequenceNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber"); }
            set
            {
                this.OnPropertyChanging("ImportSequenceNumber");
                this.SetAttributeValue("importsequencenumber", value);
                this.OnPropertyChanged("ImportSequenceNumber");
            }
        }

        /// <summary>
        /// Shows the in-progress value (decimal) against the target. This value could contribute to a goal, but is not counted yet as actual.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("inprogressdecimal")]
        public System.Nullable<decimal> InProgressDecimal
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("inprogressdecimal"); }
            set
            {
                this.OnPropertyChanging("InProgressDecimal");
                this.SetAttributeValue("inprogressdecimal", value);
                this.OnPropertyChanged("InProgressDecimal");
            }
        }

        /// <summary>
        /// Shows the in-progress value (integer) against the target. This value could contribute to a goal, but is not counted yet as actual.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("inprogressinteger")]
        public System.Nullable<int> InProgressInteger
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("inprogressinteger"); }
            set
            {
                this.OnPropertyChanging("InProgressInteger");
                this.SetAttributeValue("inprogressinteger", value);
                this.OnPropertyChanged("InProgressInteger");
            }
        }

        /// <summary>
        /// Shows the in-progress value (money) against the target. This value could contribute to a goal, but is not counted yet as actual.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("inprogressmoney")]
        public Microsoft.Xrm.Sdk.Money InProgressMoney
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("inprogressmoney"); }
            set
            {
                this.OnPropertyChanging("InProgressMoney");
                this.SetAttributeValue("inprogressmoney", value);
                this.OnPropertyChanged("InProgressMoney");
            }
        }

        /// <summary>
        /// Shows the in-progress value (money) in base currency to track goal results against the target.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("inprogressmoney_base")]
        public Microsoft.Xrm.Sdk.Money InProgressMoney_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("inprogressmoney_base"); }
        }

        /// <summary>
        /// In-progress value of the goal.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("inprogressstring")]
        public string InProgressString
        {
            get { return this.GetAttributeValue<string>("inprogressstring"); }
        }

        /// <summary>
        /// Indicates whether the metric type is Count or Amount.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isamount")]
        public System.Nullable<bool> IsAmount
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isamount"); }
            set
            {
                this.OnPropertyChanging("IsAmount");
                this.SetAttributeValue("isamount", value);
                this.OnPropertyChanged("IsAmount");
            }
        }

        /// <summary>
        /// Select whether the goal period is a fiscal period or custom period.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isfiscalperiodgoal")]
        public System.Nullable<bool> IsFiscalPeriodGoal
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isfiscalperiodgoal"); }
            set
            {
                this.OnPropertyChanging("IsFiscalPeriodGoal");
                this.SetAttributeValue("isfiscalperiodgoal", value);
                this.OnPropertyChanged("IsFiscalPeriodGoal");
            }
        }

        /// <summary>
        /// Select whether the system rollup fields are updated. If set to Yes, the next system rollup will not update the values of the rollup fields with the system calculated values.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isoverridden")]
        public System.Nullable<bool> IsOverridden
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isoverridden"); }
            set
            {
                this.OnPropertyChanging("IsOverridden");
                this.SetAttributeValue("isoverridden", value);
                this.OnPropertyChanged("IsOverridden");
            }
        }

        /// <summary>
        /// Indicates whether the values of system rollup fields can be updated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isoverride")]
        public System.Nullable<bool> IsOverride
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isoverride"); }
            set
            {
                this.OnPropertyChanging("IsOverride");
                this.SetAttributeValue("isoverride", value);
                this.OnPropertyChanged("IsOverride");
            }
        }

        /// <summary>
        /// Shows the date and time when the goal was last rolled up. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastrolledupdate")]
        public System.Nullable<System.DateTime> LastRolledupDate
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastrolledupdate"); }
            set
            {
                this.OnPropertyChanging("LastRolledupDate");
                this.SetAttributeValue("lastrolledupdate", value);
                this.OnPropertyChanged("LastRolledupDate");
            }
        }

        /// <summary>
        /// Choose the metric for the goal. This metric determines how the goal is tracked.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("metricid")]
        public Microsoft.Xrm.Sdk.EntityReference MetricId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("metricid"); }
            set
            {
                this.OnPropertyChanging("MetricId");
                this.SetAttributeValue("metricid", value);
                this.OnPropertyChanged("MetricId");
            }
        }

        /// <summary>
        /// Shows who last updated the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Shows who last updated the record on behalf of another user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Date and time that the record was migrated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
        public System.Nullable<System.DateTime> OverriddenCreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon"); }
            set
            {
                this.OnPropertyChanging("OverriddenCreatedOn");
                this.SetAttributeValue("overriddencreatedon", value);
                this.OnPropertyChanged("OverriddenCreatedOn");
            }
        }

        /// <summary>
        /// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid"); }
            set
            {
                this.OnPropertyChanging("OwnerId");
                this.SetAttributeValue("ownerid", value);
                this.OnPropertyChanged("OwnerId");
            }
        }

        /// <summary>
        /// Unique identifier for the business unit that owns the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the goal.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier for the user who owns the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Choose a parent goal if the current goal is a child goal. This sets up a parent-child relationship for reporting and analytics.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentgoalid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentGoalId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentgoalid"); }
            set
            {
                this.OnPropertyChanging("ParentGoalId");
                this.SetAttributeValue("parentgoalid", value);
                this.OnPropertyChanged("ParentGoalId");
            }
        }

        /// <summary>
        /// Shows the percentage achieved against the target goal.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("percentage")]
        public System.Nullable<decimal> Percentage
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("percentage"); }
            set
            {
                this.OnPropertyChanging("Percentage");
                this.SetAttributeValue("percentage", value);
                this.OnPropertyChanged("Percentage");
            }
        }

        /// <summary>
        /// Error code associated with rollup.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rolluperrorcode")]
        public System.Nullable<int> RollupErrorCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("rolluperrorcode"); }
            set
            {
                this.OnPropertyChanging("RollupErrorCode");
                this.SetAttributeValue("rolluperrorcode", value);
                this.OnPropertyChanged("RollupErrorCode");
            }
        }

        /// <summary>
        /// Select whether the data should be rolled up only from the child goals.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rolluponlyfromchildgoals")]
        public System.Nullable<bool> RollupOnlyFromChildGoals
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("rolluponlyfromchildgoals"); }
            set
            {
                this.OnPropertyChanging("RollupOnlyFromChildGoals");
                this.SetAttributeValue("rolluponlyfromchildgoals", value);
                this.OnPropertyChanged("RollupOnlyFromChildGoals");
            }
        }

        /// <summary>
        /// Choose the query that will be used to calculate the actual data for the goal (decimal).
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rollupqueryactualdecimalid")]
        public Microsoft.Xrm.Sdk.EntityReference RollUpQueryActualDecimalId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rollupqueryactualdecimalid"); }
            set
            {
                this.OnPropertyChanging("RollUpQueryActualDecimalId");
                this.SetAttributeValue("rollupqueryactualdecimalid", value);
                this.OnPropertyChanged("RollUpQueryActualDecimalId");
            }
        }

        /// <summary>
        /// Choose the query that will be used to calculate the actual data for the goal (integer).
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rollupqueryactualintegerid")]
        public Microsoft.Xrm.Sdk.EntityReference RollupQueryActualIntegerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rollupqueryactualintegerid"); }
            set
            {
                this.OnPropertyChanging("RollupQueryActualIntegerId");
                this.SetAttributeValue("rollupqueryactualintegerid", value);
                this.OnPropertyChanged("RollupQueryActualIntegerId");
            }
        }

        /// <summary>
        /// Choose the query that will be used to calculate the actual data for the goal (money).
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rollupqueryactualmoneyid")]
        public Microsoft.Xrm.Sdk.EntityReference RollUpQueryActualMoneyId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rollupqueryactualmoneyid"); }
            set
            {
                this.OnPropertyChanging("RollUpQueryActualMoneyId");
                this.SetAttributeValue("rollupqueryactualmoneyid", value);
                this.OnPropertyChanged("RollUpQueryActualMoneyId");
            }
        }

        /// <summary>
        /// Choose the query that will be used to calculate data for the custom rollup field (decimal).
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rollupquerycustomdecimalid")]
        public Microsoft.Xrm.Sdk.EntityReference RollUpQueryCustomDecimalId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rollupquerycustomdecimalid"); }
            set
            {
                this.OnPropertyChanging("RollUpQueryCustomDecimalId");
                this.SetAttributeValue("rollupquerycustomdecimalid", value);
                this.OnPropertyChanged("RollUpQueryCustomDecimalId");
            }
        }

        /// <summary>
        /// Choose the query that will be used to calculate data for the custom rollup field (integer).
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rollupquerycustomintegerid")]
        public Microsoft.Xrm.Sdk.EntityReference RollUpQueryCustomIntegerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rollupquerycustomintegerid"); }
            set
            {
                this.OnPropertyChanging("RollUpQueryCustomIntegerId");
                this.SetAttributeValue("rollupquerycustomintegerid", value);
                this.OnPropertyChanged("RollUpQueryCustomIntegerId");
            }
        }

        /// <summary>
        /// Choose the query that will be used to calculate data for the custom rollup field (money).
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rollupquerycustommoneyid")]
        public Microsoft.Xrm.Sdk.EntityReference RollUpQueryCustomMoneyId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rollupquerycustommoneyid"); }
            set
            {
                this.OnPropertyChanging("RollUpQueryCustomMoneyId");
                this.SetAttributeValue("rollupquerycustommoneyid", value);
                this.OnPropertyChanged("RollUpQueryCustomMoneyId");
            }
        }

        /// <summary>
        /// Choose the query that will be used to calculate data for the in-progress rollup field (decimal).
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rollupqueryinprogressdecimalid")]
        public Microsoft.Xrm.Sdk.EntityReference RollUpQueryInprogressDecimalId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rollupqueryinprogressdecimalid"); }
            set
            {
                this.OnPropertyChanging("RollUpQueryInprogressDecimalId");
                this.SetAttributeValue("rollupqueryinprogressdecimalid", value);
                this.OnPropertyChanged("RollUpQueryInprogressDecimalId");
            }
        }

        /// <summary>
        /// Choose the query that will be used to calculate data for the in-progress rollup field (integer).
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rollupqueryinprogressintegerid")]
        public Microsoft.Xrm.Sdk.EntityReference RollUpQueryInprogressIntegerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rollupqueryinprogressintegerid"); }
            set
            {
                this.OnPropertyChanging("RollUpQueryInprogressIntegerId");
                this.SetAttributeValue("rollupqueryinprogressintegerid", value);
                this.OnPropertyChanged("RollUpQueryInprogressIntegerId");
            }
        }

        /// <summary>
        /// Choose the query that will be used to calculate data for the in-progress rollup field (money).
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rollupqueryinprogressmoneyid")]
        public Microsoft.Xrm.Sdk.EntityReference RollUpQueryInprogressMoneyId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("rollupqueryinprogressmoneyid"); }
            set
            {
                this.OnPropertyChanging("RollUpQueryInprogressMoneyId");
                this.SetAttributeValue("rollupqueryinprogressmoneyid", value);
                this.OnPropertyChanged("RollUpQueryInprogressMoneyId");
            }
        }

        /// <summary>
        /// Shows whether the goal is open, completed, or canceled. Completed and canceled goals are read-only and can't be edited.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<GoalState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((GoalState) (System.Enum.ToObject(typeof(GoalState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Select the goal's status.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode"); }
            set
            {
                this.OnPropertyChanging("StatusCode");
                this.SetAttributeValue("statuscode", value);
                this.OnPropertyChanged("StatusCode");
            }
        }

        /// <summary>
        /// Select a stretch target (decimal) of the goal to define a higher or difficult level of goal than the usual ones.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stretchtargetdecimal")]
        public System.Nullable<decimal> StretchTargetDecimal
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("stretchtargetdecimal"); }
            set
            {
                this.OnPropertyChanging("StretchTargetDecimal");
                this.SetAttributeValue("stretchtargetdecimal", value);
                this.OnPropertyChanged("StretchTargetDecimal");
            }
        }

        /// <summary>
        /// Select the stretch target (integer) of the goal to define a higher or difficult level of goal than the usual ones.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stretchtargetinteger")]
        public System.Nullable<int> StretchTargetInteger
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("stretchtargetinteger"); }
            set
            {
                this.OnPropertyChanging("StretchTargetInteger");
                this.SetAttributeValue("stretchtargetinteger", value);
                this.OnPropertyChanged("StretchTargetInteger");
            }
        }

        /// <summary>
        /// Select stretch target (money) of the goal to define a higher or difficult level of goal than the usual ones.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stretchtargetmoney")]
        public Microsoft.Xrm.Sdk.Money StretchTargetMoney
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("stretchtargetmoney"); }
            set
            {
                this.OnPropertyChanging("StretchTargetMoney");
                this.SetAttributeValue("stretchtargetmoney", value);
                this.OnPropertyChanged("StretchTargetMoney");
            }
        }

        /// <summary>
        /// Shows the stretch target (money) in base currency to indicate a higher or difficult level of goal than the usual ones.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stretchtargetmoney_base")]
        public Microsoft.Xrm.Sdk.Money StretchTargetMoney_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("stretchtargetmoney_base"); }
        }

        /// <summary>
        /// Stretch target value for all data types.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stretchtargetstring")]
        public string StretchTargetString
        {
            get { return this.GetAttributeValue<string>("stretchtargetstring"); }
        }

        /// <summary>
        /// Select a goal target of the decimal type to use for tracking data that include partial numbers, such as pounds sold of a product sold by weight.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("targetdecimal")]
        public System.Nullable<decimal> TargetDecimal
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("targetdecimal"); }
            set
            {
                this.OnPropertyChanging("TargetDecimal");
                this.SetAttributeValue("targetdecimal", value);
                this.OnPropertyChanged("TargetDecimal");
            }
        }

        /// <summary>
        /// Select a goal target of the integer type to use for tracking anything countable in whole numbers, such as units sold.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("targetinteger")]
        public System.Nullable<int> TargetInteger
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("targetinteger"); }
            set
            {
                this.OnPropertyChanging("TargetInteger");
                this.SetAttributeValue("targetinteger", value);
                this.OnPropertyChanged("TargetInteger");
            }
        }

        /// <summary>
        /// Select a goal target (money) to track a monetary amount such as revenue from a product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("targetmoney")]
        public Microsoft.Xrm.Sdk.Money TargetMoney
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("targetmoney"); }
            set
            {
                this.OnPropertyChanging("TargetMoney");
                this.SetAttributeValue("targetmoney", value);
                this.OnPropertyChanged("TargetMoney");
            }
        }

        /// <summary>
        /// Shows the goal target of the money type in base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("targetmoney_base")]
        public Microsoft.Xrm.Sdk.Money TargetMoney_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("targetmoney_base"); }
        }

        /// <summary>
        /// Target value of the goal.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("targetstring")]
        public string TargetString
        {
            get { return this.GetAttributeValue<string>("targetstring"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
        public System.Nullable<int> TimeZoneRuleVersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber"); }
            set
            {
                this.OnPropertyChanging("TimeZoneRuleVersionNumber");
                this.SetAttributeValue("timezoneruleversionnumber", value);
                this.OnPropertyChanged("TimeZoneRuleVersionNumber");
            }
        }

        /// <summary>
        /// Type a title or name that describes the goal.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("title")]
        public string Title
        {
            get { return this.GetAttributeValue<string>("title"); }
            set
            {
                this.OnPropertyChanging("Title");
                this.SetAttributeValue("title", value);
                this.OnPropertyChanged("Title");
            }
        }

        /// <summary>
        /// Choose the local currency for the record to make sure budgets are reported in the correct currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid"); }
        }

        /// <summary>
        /// Unique identifier of the goal tree.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("treeid")]
        public System.Nullable<System.Guid> TreeId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("treeid"); }
        }

        /// <summary>
        /// Time zone code that was in use when the record was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
        public System.Nullable<int> UTCConversionTimeZoneCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode"); }
            set
            {
                this.OnPropertyChanging("UTCConversionTimeZoneCode");
                this.SetAttributeValue("utcconversiontimezonecode", value);
                this.OnPropertyChanged("UTCConversionTimeZoneCode");
            }
        }

        /// <summary>
        /// Version number of the goal.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N Goal_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Goal_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> Goal_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("Goal_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Goal_Annotation");
                this.SetRelatedEntities<Annotation>("Goal_Annotation", null, value);
                this.OnPropertyChanged("Goal_Annotation");
            }
        }

        /// <summary>
        /// 1:N Goal_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Goal_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Goal_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Goal_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Goal_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Goal_AsyncOperations", null, value);
                this.OnPropertyChanged("Goal_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N goal_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("goal_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> goal_connections1
        {
            get { return this.GetRelatedEntities<Connection>("goal_connections1", null); }
            set
            {
                this.OnPropertyChanging("goal_connections1");
                this.SetRelatedEntities<Connection>("goal_connections1", null, value);
                this.OnPropertyChanged("goal_connections1");
            }
        }

        /// <summary>
        /// 1:N goal_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("goal_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> goal_connections2
        {
            get { return this.GetRelatedEntities<Connection>("goal_connections2", null); }
            set
            {
                this.OnPropertyChanging("goal_connections2");
                this.SetRelatedEntities<Connection>("goal_connections2", null, value);
                this.OnPropertyChanged("goal_connections2");
            }
        }

        /// <summary>
        /// 1:N Goal_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Goal_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Goal_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Goal_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("Goal_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("Goal_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("Goal_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N Goal_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Goal_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Goal_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Goal_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("Goal_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("Goal_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("Goal_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N goal_parent_goal
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("goal_parent_goal", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Goal> Referencedgoal_parent_goal
        {
            get { return this.GetRelatedEntities<Goal>("goal_parent_goal", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedgoal_parent_goal");
                this.SetRelatedEntities<Goal>("goal_parent_goal", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedgoal_parent_goal");
            }
        }

        /// <summary>
        /// 1:N goal_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("goal_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> goal_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("goal_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("goal_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("goal_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("goal_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N Goal_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Goal_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> Goal_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("Goal_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Goal_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("Goal_ProcessSessions", null, value);
                this.OnPropertyChanged("Goal_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N Goal_RollupError_Goal
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Goal_RollupError_Goal", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Goal> ReferencedGoal_RollupError_Goal
        {
            get { return this.GetRelatedEntities<Goal>("Goal_RollupError_Goal", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("ReferencedGoal_RollupError_Goal");
                this.SetRelatedEntities<Goal>("Goal_RollupError_Goal", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("ReferencedGoal_RollupError_Goal");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_goal
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_goal")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_goal
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_goal", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_goal");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_goal", null, value);
                this.OnPropertyChanged("userentityinstancedata_goal");
            }
        }

        /// <summary>
        /// N:1 business_unit_goal
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_goal")]
        public BusinessUnit business_unit_goal
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_goal", null); }
        }

        /// <summary>
        /// N:1 goal_parent_goal
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentgoalid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("goal_parent_goal", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Goal Referencinggoal_parent_goal
        {
            get { return this.GetRelatedEntity<Goal>("goal_parent_goal", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
            set
            {
                this.OnPropertyChanging("Referencinggoal_parent_goal");
                this.SetRelatedEntity<Goal>("goal_parent_goal", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencinggoal_parent_goal");
            }
        }

        /// <summary>
        /// N:1 Goal_RollupError_Goal
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("goalwitherrorid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Goal_RollupError_Goal", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Goal ReferencingGoal_RollupError_Goal
        {
            get { return this.GetRelatedEntity<Goal>("Goal_RollupError_Goal", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
            set
            {
                this.OnPropertyChanging("ReferencingGoal_RollupError_Goal");
                this.SetRelatedEntity<Goal>("Goal_RollupError_Goal", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("ReferencingGoal_RollupError_Goal");
            }
        }

        /// <summary>
        /// N:1 goal_rollupquery_actualdecimal
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rollupqueryactualdecimalid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("goal_rollupquery_actualdecimal")]
        public GoalRollupQuery goal_rollupquery_actualdecimal
        {
            get { return this.GetRelatedEntity<GoalRollupQuery>("goal_rollupquery_actualdecimal", null); }
            set
            {
                this.OnPropertyChanging("goal_rollupquery_actualdecimal");
                this.SetRelatedEntity<GoalRollupQuery>("goal_rollupquery_actualdecimal", null, value);
                this.OnPropertyChanged("goal_rollupquery_actualdecimal");
            }
        }

        /// <summary>
        /// N:1 goal_rollupquery_actualmoney
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rollupqueryactualmoneyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("goal_rollupquery_actualmoney")]
        public GoalRollupQuery goal_rollupquery_actualmoney
        {
            get { return this.GetRelatedEntity<GoalRollupQuery>("goal_rollupquery_actualmoney", null); }
            set
            {
                this.OnPropertyChanging("goal_rollupquery_actualmoney");
                this.SetRelatedEntity<GoalRollupQuery>("goal_rollupquery_actualmoney", null, value);
                this.OnPropertyChanged("goal_rollupquery_actualmoney");
            }
        }

        /// <summary>
        /// N:1 goal_rollupquery_customdecimal
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rollupquerycustomdecimalid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("goal_rollupquery_customdecimal")]
        public GoalRollupQuery goal_rollupquery_customdecimal
        {
            get { return this.GetRelatedEntity<GoalRollupQuery>("goal_rollupquery_customdecimal", null); }
            set
            {
                this.OnPropertyChanging("goal_rollupquery_customdecimal");
                this.SetRelatedEntity<GoalRollupQuery>("goal_rollupquery_customdecimal", null, value);
                this.OnPropertyChanged("goal_rollupquery_customdecimal");
            }
        }

        /// <summary>
        /// N:1 goal_rollupquery_customint
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rollupquerycustomintegerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("goal_rollupquery_customint")]
        public GoalRollupQuery goal_rollupquery_customint
        {
            get { return this.GetRelatedEntity<GoalRollupQuery>("goal_rollupquery_customint", null); }
            set
            {
                this.OnPropertyChanging("goal_rollupquery_customint");
                this.SetRelatedEntity<GoalRollupQuery>("goal_rollupquery_customint", null, value);
                this.OnPropertyChanged("goal_rollupquery_customint");
            }
        }

        /// <summary>
        /// N:1 goal_rollupquery_custommoney
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rollupquerycustommoneyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("goal_rollupquery_custommoney")]
        public GoalRollupQuery goal_rollupquery_custommoney
        {
            get { return this.GetRelatedEntity<GoalRollupQuery>("goal_rollupquery_custommoney", null); }
            set
            {
                this.OnPropertyChanging("goal_rollupquery_custommoney");
                this.SetRelatedEntity<GoalRollupQuery>("goal_rollupquery_custommoney", null, value);
                this.OnPropertyChanged("goal_rollupquery_custommoney");
            }
        }

        /// <summary>
        /// N:1 goal_rollupquery_inprogressdecimal
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rollupqueryinprogressdecimalid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("goal_rollupquery_inprogressdecimal")]
        public GoalRollupQuery goal_rollupquery_inprogressdecimal
        {
            get { return this.GetRelatedEntity<GoalRollupQuery>("goal_rollupquery_inprogressdecimal", null); }
            set
            {
                this.OnPropertyChanging("goal_rollupquery_inprogressdecimal");
                this.SetRelatedEntity<GoalRollupQuery>("goal_rollupquery_inprogressdecimal", null, value);
                this.OnPropertyChanged("goal_rollupquery_inprogressdecimal");
            }
        }

        /// <summary>
        /// N:1 goal_rollupquery_inprogressint
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rollupqueryinprogressintegerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("goal_rollupquery_inprogressint")]
        public GoalRollupQuery goal_rollupquery_inprogressint
        {
            get { return this.GetRelatedEntity<GoalRollupQuery>("goal_rollupquery_inprogressint", null); }
            set
            {
                this.OnPropertyChanging("goal_rollupquery_inprogressint");
                this.SetRelatedEntity<GoalRollupQuery>("goal_rollupquery_inprogressint", null, value);
                this.OnPropertyChanged("goal_rollupquery_inprogressint");
            }
        }

        /// <summary>
        /// N:1 goal_rollupquery_inprogressmoney
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rollupqueryinprogressmoneyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("goal_rollupquery_inprogressmoney")]
        public GoalRollupQuery goal_rollupquery_inprogressmoney
        {
            get { return this.GetRelatedEntity<GoalRollupQuery>("goal_rollupquery_inprogressmoney", null); }
            set
            {
                this.OnPropertyChanging("goal_rollupquery_inprogressmoney");
                this.SetRelatedEntity<GoalRollupQuery>("goal_rollupquery_inprogressmoney", null, value);
                this.OnPropertyChanged("goal_rollupquery_inprogressmoney");
            }
        }

        /// <summary>
        /// N:1 goalrollupquery_actualint
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rollupqueryactualintegerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("goalrollupquery_actualint")]
        public GoalRollupQuery goalrollupquery_actualint
        {
            get { return this.GetRelatedEntity<GoalRollupQuery>("goalrollupquery_actualint", null); }
            set
            {
                this.OnPropertyChanging("goalrollupquery_actualint");
                this.SetRelatedEntity<GoalRollupQuery>("goalrollupquery_actualint", null, value);
                this.OnPropertyChanged("goalrollupquery_actualint");
            }
        }

        /// <summary>
        /// N:1 lk_goal_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_goal_createdby")]
        public SystemUser lk_goal_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_goal_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_goal_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_goal_createdonbehalfby")]
        public SystemUser lk_goal_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_goal_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_goal_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_goal_modifiedby")]
        public SystemUser lk_goal_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_goal_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_goal_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_goal_modifiedonbehalfby")]
        public SystemUser lk_goal_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_goal_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 metric_goal
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("metricid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("metric_goal")]
        public Metric metric_goal
        {
            get { return this.GetRelatedEntity<Metric>("metric_goal", null); }
            set
            {
                this.OnPropertyChanging("metric_goal");
                this.SetRelatedEntity<Metric>("metric_goal", null, value);
                this.OnPropertyChanged("metric_goal");
            }
        }

        /// <summary>
        /// N:1 team_goal
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_goal")]
        public Team team_goal
        {
            get { return this.GetRelatedEntity<Team>("team_goal", null); }
        }

        /// <summary>
        /// N:1 team_goal_goalowner
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("goalownerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_goal_goalowner")]
        public Team team_goal_goalowner
        {
            get { return this.GetRelatedEntity<Team>("team_goal_goalowner", null); }
            set
            {
                this.OnPropertyChanging("team_goal_goalowner");
                this.SetRelatedEntity<Team>("team_goal_goalowner", null, value);
                this.OnPropertyChanged("team_goal_goalowner");
            }
        }

        /// <summary>
        /// N:1 TransactionCurrency_Goal
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Goal")]
        public TransactionCurrency TransactionCurrency_Goal
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_Goal", null); }
        }

        /// <summary>
        /// N:1 user_goal
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_goal")]
        public SystemUser user_goal
        {
            get { return this.GetRelatedEntity<SystemUser>("user_goal", null); }
        }

        /// <summary>
        /// N:1 user_goal_goalowner
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("goalownerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_goal_goalowner")]
        public SystemUser user_goal_goalowner
        {
            get { return this.GetRelatedEntity<SystemUser>("user_goal_goalowner", null); }
            set
            {
                this.OnPropertyChanging("user_goal_goalowner");
                this.SetRelatedEntity<SystemUser>("user_goal_goalowner", null, value);
                this.OnPropertyChanged("user_goal_goalowner");
            }
        }
    }
}