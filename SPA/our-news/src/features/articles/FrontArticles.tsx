import React, {Fragment, useState, useEffect} from 'react'
import {Grid, Segment, Image, Header,Item, Container} from 'semantic-ui-react';
import { IArticle } from '../../app/models/article';
import agent from '../../app/api/agent';
import styles from './FrontArticles.style';


const FrontArticles = () => {

    const [articles, setArticles] = useState<IArticle[]>([]);

    useEffect(() => {
  
        agent.Articles.frontArticles().then(response => {
          setArticles(response)
          console.log(response)
        });
    
        return () => {
          
        }
      }, [])
  
    return (
        <Fragment>
            { 
            articles.length > 0 &&  
            <Grid style={{marginTop: "10px"}}>
            <Grid.Row>
                
                    <Grid.Column width={8} style={styles.gridColumnOne}>   
                        <Segment basic style={styles.segmentFirstSecond}>                                  
                        <Image src={articles[0].mainPhoto} as="img" 
                            style={styles.mainImageStyle} />                                                                                      
                            <Item.Group style={styles.mainImageTextStyle}>
                                <Item >
                                    <Item.Content  style={styles.mainPageTextWrapper}>
                                        <Item.Meta style={styles.mainMetaDataArticle}>
                                            {articles[0].category}
                                        </Item.Meta>
                                        <Header size="huge" 
                                            content={articles[0].title}
                                            style={{ color: 'white' }}
                                        />
                                        <p>{articles[0].description}</p>
                                    </Item.Content>
                                </Item>
                            </Item.Group>                                                                                           
                            </Segment>                                                        
                    </Grid.Column>
                <Grid.Column width={5} style={styles.gridColumnOne}>
                        <Segment basic style={styles.segmentFirstSecond}>               
                        <Image src={articles[1].mainPhoto} style={styles.mainImageStyle} />                                                        
                            <Item.Group style={styles.mainImageTextStyle}>
                                <Item >
                                    <Item.Content style={styles.mainPageTextWrapper}>
                                        <Item.Meta style={styles.mainMetaDataArticle}>
                                            {articles[1].category}
                                        </Item.Meta>
                                        <Header size="huge" 
                                            content={articles[1].title}
                                            style={{ color: 'white' }}
                                        />
                                        <p>{articles[1].description}</p>
                                    </Item.Content>
                                </Item>
                        </Item.Group>  
                        </Segment>                                                                
                </Grid.Column>
                <Grid.Column width={3} style={styles.gridColumnOne}>                               
                        <Grid.Column style={styles.gridColumnTwo}>                              
                            <Segment basic style={styles.segmentThirdFourth}>
                                <Image src={articles[2].mainPhoto} 
                                    style={styles.mainThirdthImageStyle}/>                                                  
                                    <Item.Group style={styles.mainImageTextStyle}>
                                        <Item >
                                            <Item.Content style={styles.mainPageTextWrapper}>
                                                <Item.Meta style={styles.mainMetaDataArticle}>
                                                    {articles[2].category}
                                                </Item.Meta>
                                                <Header size="medium" 
                                                    content={articles[2].title}
                                                    style={{ color: 'white' }}
                                                />
                                                <p>{articles[2].description}</p>
                                            </Item.Content>
                                        </Item>
                                    </Item.Group>                                                                                    
                            </Segment> 
                    </Grid.Column>
                        <Grid.Column style={styles.gridColumnTwo}>
                            <Segment basic style={styles.segmentThirdFourth}>
                                <Image src={articles[3].mainPhoto} 
                                    style={styles.mainThirdthImageStyle}/>                                                        
                                <Item.Group style={styles.mainImageTextStyle}>
                                    <Item >
                                        <Item.Content style={styles.mainPageTextWrapper}>
                                            <Item.Meta style={styles.mainMetaDataArticle}>
                                                {articles[3].category}
                                            </Item.Meta>
                                            <Header size="medium" 
                                                content={articles[3].title}
                                                style={{ color: 'white' }}
                                            />
                                            <p>{articles[3].description}</p>
                                        </Item.Content>
                                    </Item>
                                </Item.Group>                                                             
                            </Segment>  
                        </Grid.Column>

                    </Grid.Column>
                </Grid.Row>
            </Grid>
             }
        </Fragment>
    )
}


export default FrontArticles
