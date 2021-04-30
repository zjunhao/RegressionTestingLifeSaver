using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegressionTestingLifeSaver.Models;

namespace RegressionTestingLifeSaver.Services
{
    public class MockDataSourceService
    {
        public static TestPlan populateTestPlan(int testPlanID)
        {
            TestPlan testPlan = new TestPlan()
            {
                PlanName = "Unity Client | Viewer"
            };

            string[] caseNames = { "Viewer Permissions", "Image Viewers", "PDF Viewers" };

            // Viewer Permissions Tests
            Test viewerPermmsions1 = new Test
            {
                TestName = "Ensure that documents may not be retrieved / viewed in the External and Embedded Viewers when the User Group Privilege is disabled",
                TestSteps = @"Automated UI tests can be found in Hyland.Canvas.Client.UIA.Regression.Tests.Viewer.ViewerPrivilegesTests.
Run the automated UI tests with TestTemplateId: 218489.
Verify the document cannot be viewed without proper privileges.",
                ExpectedResult = "Documents may not be retrieved or viewed when a user does not have the privilege to do so.",
                Criticality = "Criticality 1-High"
            };
            Test viewerPermmsions2 = new Test
            {
                TestName = "Ensure that documents may be viewed when a user has the Retrieve / View User Group privilege enabled in the external and embedded viewers",
                TestSteps = @"Automated UI tests can be found in Hyland.Canvas.Client.UIA.Regression.Tests.Viewer.ViewerPrivilegesTests.
Run the automated UI tests with TestTemplateId: 218490.
Verify that viewing was successful.",
                ExpectedResult = "Users with the Retrieve / View privilege may retrieve and view documents in the viewer.",
                Criticality = "Criticality 1-High"
            };

            // Image Viewer Tests
            Test imageViewer1 = new Test
            {
                TestName = "Image File Formats",
                TestSteps = @"Automated UI tests can be found in Hyland.Canvas.Client.UIA.Regression.Tests.Viewer.ImageViewerTests.
Run the automated UI tests with TestTemplateId: 218501.
Verify the following file formats display properly in the embedded and external viewers:

.PNG
.JPEG
Below 300 DPI
Above 300 DPI
.BMP
8 - bit
24 - bit
.TIF
CCITT T.6 compression
JPEG compression
LZW compression
Uncompressed
Below 100 DPI
At or above 600 DPI
Single Page
Multi-Page
.GIF
8 - bit (NI)
2-bit
3-bit
4-bit
5-bit
6-bit
7-bit
8-bit
.ICO
.EMF
Note: Snowbound does not support EMF files and it will display the document in black and white",
                ExpectedResult = "Be sure to test in the external and embedded viewers. Supported Image file formats display properly.",
                Criticality = "Criticality 1-High"
            };
            Test imageViewer2 = new Test
            {
                TestName = "Tabs | Ribbons | Buttons  for image documents",
                TestSteps = @"
Verify that the following tabs are present:
Document
Image
Signatures
Markups (If the DT is revisable)
Tasks (If there is a Workflow configured)",
                ExpectedResult = "The correct tabs display for TIFF-rendered images,",
                Criticality = "Criticality 1-High"
            };
            Test imageViewer3 = new Test
            {
                TestName = "Modifications to image documents in the embedded and external viewers",
                TestSteps = @"Automated UI tests can be found in Hyland.Canvas.Client.UIA.Regression.Tests.Viewer.ImageViewerTests.
Run the automated UI tests with TestTemplateId: 218503.
Verify the following buttons perform the associated actions correctly:

Selection Zoom - Enlarges the viewer of the document.
Hand Tool - Pans the document in any direction.
Previous/Next Document - View the previous document in the hit list. View the next document in the hitlist.
Previous/Next Page - Navigates to the previous page in the document (multi-page). Navigates to the next page in the document (multi-page).
First/Last Page - Navigates to the first or last page of the document (multi-page).
Go To Page - Navigates to the specified page in the document.
Toggle Thumbnails - Toggles thumbnails on and off.
Zoom In/Out - Zooms in and out on the center of the document.
% Zoom - Zooms in a specified percentage.
Actual Size - Displays the document as it's actual size.
Fit To Width - Fits the document to the window according to the width.
Fit To Window - The Viewer will scale so the whole image fits in the window.
Rotate Left - Rotates the document to the left.
Rotate Right - Rotates the document to the right.
Flip Horizontally - Flips the document horizontally.
Flip Vertically - Flips the document vertically.
Save Flip & Rotation - Saves any flips/rotations that were performed.
Note: Rotations on an image document cannot be saved in conjunction with flips. The orientation of the page will not be correct. (SCR #272288)

Note:",
                ExpectedResult = "Image document modifications function properly in the external and embedded image viewers.",
                Criticality = "Criticality 1-High"
            };

            // PDF Viewer Tests
            Test pdfViewer1 = new Test
            {
                TestName = "Single Page PDF",
                TestSteps = @"Automated UI tests can be found in Hyland.Canvas.Client.UIA.Regression.Tests.Viewer.PDFViewerTests.
Run the automated UI tests with TestTemplateId: 218517.
1. Verify the document renders correct

2. Verify that the page count button on the information banner indicates 1 page

Be sure to test in the external and embedded viewer",
                ExpectedResult = "PDF documents render correctly and a 1 page PDF document displays the correct page count on the information banner.",
                Criticality = "Criticality 2-Medium"
            };

            // Add tests to testplan
            testPlan.testCases = new List<TestCase>();

            TestCase viewerPermission = new TestCase()
            {
                CaseName = "Viewer Permissions"
            };
            viewerPermission.tests = new List<Test>();
            viewerPermission.tests.Add(viewerPermmsions1);
            viewerPermission.tests.Add(viewerPermmsions2);
            testPlan.testCases.Add(viewerPermission);

            TestCase imageViewer = new TestCase()
            {
                CaseName = "Image Viewers"
            };
            imageViewer.tests = new List<Test>();
            imageViewer.tests.Add(imageViewer1);
            imageViewer.tests.Add(imageViewer2);
            imageViewer.tests.Add(imageViewer3);
            testPlan.testCases.Add(imageViewer);

            TestCase pdfViewer = new TestCase()
            {
                CaseName = "PDF Viewers"
            };
            viewerPermission.tests = new List<Test>();
            viewerPermission.tests.Add(pdfViewer1);
            testPlan.testCases.Add(pdfViewer);

            return testPlan;
        }
    }
}
