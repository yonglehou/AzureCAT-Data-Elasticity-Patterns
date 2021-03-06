﻿#region usings

using System;
using System.Web.UI;
using Microsoft.AzureCat.Patterns.Data.Elasticity;
using Microsoft.AzureCat.Patterns.Data.Elasticity.Models;
using Microsoft.AzureCat.Patterns.Data.Elasticity.Models.QueueMessages;

#endregion

namespace Microsoft.AzureCat.Patterns.DataElasticity.Azure.WebConsole.Queues
{
    public partial class ShardDeletionQueue : Page
    {
        #region methods

        protected void Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect(string.Format("~/Queues/ShardDeletionQueue.aspx?Status={1}", Request.QueryString["id"],
                Filter.SelectedValue));
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Title = "Shard Deletion Queue";
            if (IsPostBack) return;
            
            if (Request.QueryString["Status"] != null)
            {
                for (var i = 0; i < Filter.Items.Count; i++)
                {
                    if (Filter.Items[i].Value == Request.QueryString["Status"])
                    {
                        Filter.SelectedIndex = i;
                        break;
                    }
                }
            }
            else
            {
                Filter.SelectedIndex = 0;
            }
            
            LoadList();
        }

        private void LoadList()
        {
            var filter = TableActionQueueItemStatus.Queued;
            try
            {
                filter =
                    (TableActionQueueItemStatus)
                        Enum.Parse(typeof (TableActionQueueItemStatus), Filter.SelectedValue);
            }
            catch
            {
                Response.Redirect("~/Queues/default.aspx");
            }

            queueList.DataSource = TableGroupActionQueue.GetQueuedRequestsByStatus<ShardDeletionRequest>(filter);
            queueList.DataBind();
        }

        #endregion
    }
}