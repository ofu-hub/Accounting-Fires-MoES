using MoesApp.Views.Windows;
using MoesApp.Data;
using MoesApp.Models;
using MoesApp.ViewModels.Base;
using MoesApp.Commands;
using System;
using System.Windows.Controls;
using System.Windows;

namespace MoesApp.ViewModels
{
    internal class ReportViewModel : ViewModelBase
    {
        #region Заголовок окна

        private string _Title = "Отчет о пожаре";

        /// <summary>
        /// Заголовок окна
        /// </summary>
        public string Title
        {
            get { return _Title; }
            set => Set(ref _Title, value);
        }

        #endregion

        #region Добавление данных
        // - Общие сведения
        public string orgCode { get; set; } = string.Empty;
        public DateTime dateFire { get; set; } = DateTime.Now;
        public string typeCode { get; set; } = string.Empty;
        public string typeFireCode { get; set; } = string.Empty;
        // - Объект пожара
        public string subjectCode { get; set; } = string.Empty;
        public string subTypeOwnerCode { get; set; } = string.Empty;
        public string objRiskCode { get; set; } = string.Empty;
        public string kindFireObjCode { get; set; } = string.Empty;
        public string nameFireObjCode { get; set; } = string.Empty;
        public string floorsObjCode { get; set; } = string.Empty;
        public string floorWhereFireCode { get; set; } = string.Empty;
        public string locationFireCode { get; set; } = string.Empty;
        public string causeFireCode { get; set; } = string.Empty;
        public string guiltyPersonCode { get; set; } = string.Empty;
        public string attitudePersonCode { get; set; } = string.Empty;
        public string statePersonCode { get; set; } = string.Empty;
        // - Последствия пожара
        public string peopleDiedAll { get; set; } = string.Empty;
        public string peopleDiedKids { get; set; } = string.Empty;
        public string peopleDiedWork { get; set; } = string.Empty;
        public string peopleInjuredAll { get; set; } = string.Empty;
        public string peopleInjuredKids { get; set; } = string.Empty;
        public string peopleInjuredWork { get; set; } = string.Empty;
        public string mFireDamage { get; set; } = string.Empty;
        public string buildDest { get; set; } = string.Empty;
        public string buildDam { get; set; } = string.Empty;
        public string apartDest { get; set; } = string.Empty;
        public string apartDam { get; set; } = string.Empty;
        // - Эвакуировано на пожаре
        public string peopleSaved { get; set; } = string.Empty;
        public string peopleEvacuated { get; set; } = string.Empty;
        public string cattleLarge { get; set; } = string.Empty;
        public string cattleSmall { get; set; } = string.Empty;
        public string technique { get; set; } = string.Empty;
        public string matValues { get; set; } = string.Empty;
        // - Развитие и тушение пожара 
        public string detectionTime { get; set; } = string.Empty;
        public string messageTime { get; set; } = string.Empty;
        public string arrivalTime1st { get; set; } = string.Empty;
        public string localTime { get; set; } = string.Empty;
        public string openFireEliTime { get; set; } = string.Empty;
        public string eliFireTime { get; set; } = string.Empty;
        public DateTime liquidationDate { get; set; } = DateTime.Now;
        // - Силы и средства пожаротушения 
        public string firefighters { get; set; } = string.Empty;
        public string two_technique { get; set; } = string.Empty;
        public string numTechnique { get; set; } = string.Empty;
        public string individProtect { get; set; } = string.Empty;
        public string waterOnFire { get; set; } = string.Empty;
        public string fireExtManager { get; set; } = string.Empty;
        public string fireFightingHead { get; set; } = string.Empty;
        public string investigativeTeam { get; set; } = string.Empty;
        public string fireExtAgents { get; set; } = string.Empty;
        public string primaryFireEquip { get; set; } = string.Empty;
        // - Сведения о погибших и травмированных 
        public string genderDead { get; set; } = string.Empty;
        public string socStatus { get; set; } = string.Empty;
        public string educationDead { get; set; } = string.Empty;
        public string causeDead { get; set; } = string.Empty;
        public string termsDead { get; set; } = string.Empty;
        public string momentDead { get; set; } = string.Empty;
        public string termsInjury { get; set; } = string.Empty;
        public string harmHealth { get; set; } = string.Empty;
        public string ageDead { get; set; } = string.Empty;
        // - Отчет
        public string name { get; set; } = string.Empty;
        public GenInfo genInfo { get; set; } = new GenInfo();
        public FireObj fireObj { get; set; } = new FireObj();
        public FireConsequence fireConsequence { get; set; } = new FireConsequence();
        public FireRescued fireRescued { get; set; } = new FireRescued();
        public FireDevExt fireDevExt { get; set; } = new FireDevExt();
        public FireForcesMean fireForcesMean { get; set; } = new FireForcesMean();
        public InfoDeadAInjured infoDeadAInjured { get; set; } = new InfoDeadAInjured();

        private RelayCommand _AddNewFileReport;

        public RelayCommand AddNewFileReport
        {
            get
            {
                return _AddNewFileReport ?? new RelayCommand(obj =>
                {
                    SendFileReport();
                });
            }
        }
        public void SendFileReport()
        {
            string result = string.Empty;
            bool flag = true;

            if (orgCode != string.Empty && typeCode != string.Empty && typeFireCode != string.Empty)
            {
                if (subjectCode != string.Empty && subTypeOwnerCode != string.Empty && objRiskCode != string.Empty &&
                        kindFireObjCode != string.Empty && nameFireObjCode != string.Empty && floorsObjCode != string.Empty &&
                        floorWhereFireCode != string.Empty && locationFireCode != string.Empty && causeFireCode != string.Empty &&
                        guiltyPersonCode != string.Empty && attitudePersonCode != string.Empty && statePersonCode != string.Empty)
                {
                    if (peopleDiedAll != string.Empty && peopleDiedKids != string.Empty && peopleDiedWork != string.Empty &&
                        peopleInjuredAll != string.Empty && peopleInjuredKids != string.Empty && peopleInjuredWork != string.Empty &&
                        mFireDamage != string.Empty && buildDest != string.Empty && buildDam != string.Empty &&
                        apartDest != string.Empty && apartDam != string.Empty)
                    {
                        if (peopleSaved != string.Empty && peopleEvacuated != string.Empty && cattleLarge != string.Empty &&
                            cattleSmall != string.Empty && technique != string.Empty && matValues != string.Empty)
                        {
                            if (detectionTime != string.Empty && messageTime != string.Empty && arrivalTime1st != string.Empty &&
                                        localTime != string.Empty && openFireEliTime != string.Empty && eliFireTime != string.Empty)
                            {
                                if (firefighters != string.Empty && two_technique != string.Empty && numTechnique != string.Empty &&
                                       individProtect != string.Empty && waterOnFire != string.Empty && fireExtManager != string.Empty &&
                                       fireFightingHead != string.Empty && investigativeTeam != string.Empty && fireExtAgents != string.Empty &&
                                       primaryFireEquip != string.Empty)
                                {
                                    if (genderDead != string.Empty && socStatus != string.Empty && educationDead != string.Empty &&
                                        causeDead != string.Empty && termsDead != string.Empty && momentDead != string.Empty &&
                                        termsInjury != string.Empty && harmHealth != string.Empty && ageDead != string.Empty)
                                    {

                                        if (name != string.Empty)
                                        {
                                            genInfo = DataGenInfo.CreateGenInfo(orgCode, dateFire, typeCode, typeFireCode);
                                            fireObj = DataFireObj.CreateFireObj(subjectCode, subTypeOwnerCode, objRiskCode, kindFireObjCode, nameFireObjCode,
                                                floorsObjCode, floorWhereFireCode, locationFireCode, causeFireCode, guiltyPersonCode, attitudePersonCode, statePersonCode);
                                            fireConsequence = DataFireConsequence.CreateFireConsequence(peopleDiedAll, peopleDiedKids, peopleDiedWork, peopleInjuredAll, peopleInjuredKids,
                                                                                                        peopleInjuredWork, mFireDamage, buildDest, buildDam, apartDest, apartDam);
                                            fireRescued = DataFireRescued.CreateFireRescued(peopleSaved, peopleEvacuated, cattleLarge,
                                                                                        cattleSmall, technique, matValues);
                                            fireDevExt = DataFireDevExt.CreateFireDevExt(detectionTime, messageTime, arrivalTime1st,
                                                                                localTime, openFireEliTime, eliFireTime, liquidationDate);
                                            fireForcesMean = DataFireForcesMean.CreateFireForcesMean(firefighters, two_technique, numTechnique,
                                                                                            individProtect, waterOnFire, fireExtManager,
                                                                                            fireFightingHead, investigativeTeam, fireExtAgents, primaryFireEquip);
                                            infoDeadAInjured = DataInfoDeadAInjured.CreateInfoDeadAInjured(genderDead, socStatus, educationDead, causeDead,
                                                                                                termsDead, momentDead, termsInjury, harmHealth, ageDead);
                                            result = DataFileReport.CreateFileReport(name, genInfo, fireObj, fireConsequence, fireRescued,
                                                                                        fireDevExt, fireForcesMean, infoDeadAInjured);
                                        }
                                        else
                                            flag = false;
                                    }
                                    else
                                        flag = false;
                                }
                                else
                                    flag = false;
                            }
                            else
                                flag = false;
                        }
                        else
                            flag = false;
                    }
                    else
                        flag = false;
                }
                else
                    flag = false;
            }
            else
                flag = false;

            if (flag == false)
            {
                string caption = "Уведомление";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBoxResult mbox;

                mbox = MessageBox.Show("Добавление невозможно, заполнены не все поля!", caption, button, icon, MessageBoxResult.Yes);
            }
            else
            {
                string caption = "Уведомление";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Information;
                MessageBoxResult mbox;

                mbox = MessageBox.Show(result, caption, button, icon, MessageBoxResult.Yes);
            }
        }
        #endregion
    }
}
