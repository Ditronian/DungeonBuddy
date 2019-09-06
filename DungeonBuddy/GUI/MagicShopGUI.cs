using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DungeonBuddy.Entities;
using DungeonBuddy.Main;
using DungeonBuddy.Biome;
using DungeonBuddy.Items;
using DungeonBuddy.Tables;

namespace DungeonBuddy.GUI
{
    public partial class Form1 : Form
    {

        //Generates the appropriate shop after clearing the old one
        private void generateShopButton_Click(object sender, EventArgs e)
        {
            //Remove old items from list and listview
            DungeonBuddy.Main.Main.MagicItems.Clear();
            magicItemShopListView.ClearObjects();

            //Determine selected Shop Quality and generate appropriate items
            if (magicItemShopQualityComboBox.Text == "Common") generateCommonShop();
            else if (magicItemShopQualityComboBox.Text == "Uncommon") generateUncommonShop();
            else if(magicItemShopQualityComboBox.Text == "Rare") generateRareShop();
            else if (magicItemShopQualityComboBox.Text == "Very Rare") generateVeryRareShop();
            else if (magicItemShopQualityComboBox.Text == "Legendary") generateLegendaryShop();

            //Save when finished
            Main.Save.save();
        }

        //Generates items from the Common Magic Item Tables
        private void generateCommonShop(int core = 10, int wonderous = 1)
        {
            List<MagicItem> magicItems = new List<MagicItem>();
            for (int i = 0; i < core; i++)
            {
                MagicItem item = MagicItemTable.getItem("A");
                DungeonBuddy.Main.Main.MagicItems.Add(item);
                magicItemShopListView.AddObject(item);
            }
            for (int i = 0; i < wonderous; i++)
            {
                MagicItem item = MagicItemTable.getItem("F");
                DungeonBuddy.Main.Main.MagicItems.Add(item);
                magicItemShopListView.AddObject(item);
            }
        }

        //Generates items from the Uncommon Magic Item Tables
        private void generateUncommonShop(int core = 9, int wonderous = 3)
        {
            List<MagicItem> magicItems = new List<MagicItem>();
            for (int i = 0; i < core; i++)
            {
                MagicItem item = MagicItemTable.getItem("B");
                DungeonBuddy.Main.Main.MagicItems.Add(item);
                magicItemShopListView.AddObject(item);
            }
            for (int i = 0; i < wonderous; i++)
            {
                MagicItem item = MagicItemTable.getItem("F");
                DungeonBuddy.Main.Main.MagicItems.Add(item);
                magicItemShopListView.AddObject(item);
            }
            generateCommonShop(6,0);
        }

        //Generates items from the Rare Magic Item Tables
        private void generateRareShop(int core = 8, int wonderous = 2)
        {
            List<MagicItem> magicItems = new List<MagicItem>();
            for (int i = 0; i < core; i++)
            {
                MagicItem item = MagicItemTable.getItem("C");
                DungeonBuddy.Main.Main.MagicItems.Add(item);
                magicItemShopListView.AddObject(item);
            }
            for (int i = 0; i < wonderous; i++)
            {
                MagicItem item = MagicItemTable.getItem("G");
                DungeonBuddy.Main.Main.MagicItems.Add(item);
                magicItemShopListView.AddObject(item);
            }
            generateUncommonShop(4, 2);
        }

        //Generates items from the Very Rare Magic Item Tables
        private void generateVeryRareShop(int core = 6, int wonderous = 2)
        {
            List<MagicItem> magicItems = new List<MagicItem>();
            for (int i = 0; i < core; i++)
            {
                MagicItem item = MagicItemTable.getItem("D");
                DungeonBuddy.Main.Main.MagicItems.Add(item);
                magicItemShopListView.AddObject(item);
            }
            for (int i = 0; i < wonderous; i++)
            {
                MagicItem item = MagicItemTable.getItem("H");
                DungeonBuddy.Main.Main.MagicItems.Add(item);
                magicItemShopListView.AddObject(item);
            }
            generateRareShop(4, 2);
        }

        //Generates items from the Legendary Magic Item Tables
        private void generateLegendaryShop(int core = 4, int wonderous = 2)
        {
            List<MagicItem> magicItems = new List<MagicItem>();
            for (int i = 0; i < core; i++)
            {
                MagicItem item = MagicItemTable.getItem("E");
                DungeonBuddy.Main.Main.MagicItems.Add(item);
                magicItemShopListView.AddObject(item);
            }
            for (int i = 0; i < wonderous; i++)
            {
                MagicItem item = MagicItemTable.getItem("I");
                DungeonBuddy.Main.Main.MagicItems.Add(item);
                magicItemShopListView.AddObject(item);
            }
            generateVeryRareShop(3, 2);
        }

    }
}
